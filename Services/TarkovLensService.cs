﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TarkovLensBot.Enums;
using TarkovLensBot.Interfaces;
using TarkovLensBot.Models.Items;

namespace TarkovLensBot.Services
{
    public class TarkovLensService
    {
        private readonly HttpClient httpClient;

        public TarkovLensService(HttpClient client, IConfiguration Configuration)
        {
            var config = new Config();
            Configuration.Bind(config);

            client.BaseAddress = new Uri(config.TarkovLensAPIUrl);
            httpClient = client;
        }

        public async Task<List<BaseItem>> GetItemsBySearch(string nameOfItem)
        {
            var response = await httpClient.GetAsync($"item/search?name={nameOfItem}");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            var items = JsonSerializer.Deserialize<List<BaseItem>>(json);

            return items;
        }

        /// <summary>
        /// Get a list of all ammunitions.
        /// </summary>
        /// <param name="nameOfItem">OPTIONAL: search for ammunitions by name</param>
        /// /// <param name="caliber">OPTIONAL: search for ammunitions by caliber</param>
        /// <returns>A list of Ammunition objects.</returns>
        public async Task<List<Ammunition>> GetAmmunitions(string nameOfItem = null, string caliber = null)
        {
            var response = await httpClient.GetAsync($"item/kind/{KindOfItem.Ammunition}?name={nameOfItem}&caliber={caliber}");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            
            JsonSerializerOptions options = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
            var items = JsonSerializer.Deserialize<List<Ammunition>>(json, options);

            return items;
        }
    }
}
