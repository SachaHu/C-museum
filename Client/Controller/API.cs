﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MuseeApi.Models;

using Newtonsoft.Json;
namespace Client.Controller
{
    public sealed class API
    {
        private static readonly HttpClient client = new HttpClient();
        private API()
        {
            client.BaseAddress = new Uri("https://localhost:44303/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private static readonly object padlock = new object();
        private static API instance = null;

        public static API Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new API();
                    }
                    return instance;
                }
            }
        }

        public async Task<ICollection<Activity>> GetActivitiesAsync()
        {
            ICollection<Activity> activities  = new List<Activity>();
            HttpResponseMessage response = client.GetAsync("Api/Activities").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                activities = JsonConvert.DeserializeObject<List<Activity>>(resp);
            }
            return activities;
        }

        public async Task<Activity> GetEcurieAsync(int? id)
        {
            Activity activity  = null;
            HttpResponseMessage response = client.GetAsync("Api/Activities/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                activity = JsonConvert.DeserializeObject<Activity>(resp);
            }
            return activity;
        }

        public async Task<Uri> AjoutEcurieAsync(Activity activity)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("Api/Activities", activity);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public async Task<Uri> ModifEcurieAsync(Activity activity)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("Api/Activities/" + activity.Id, activity);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


        public async Task<Uri> SupprEcurieAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("Api/Activities/" + id);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public async Task<ICollection<Tag>> GetTagsAsync()
        {
            ICollection<Tag> tags = new List<Tag>();
            HttpResponseMessage response = client.GetAsync("Api/Tags").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                tags = JsonConvert.DeserializeObject<List<Tag>>(resp);
            }
            return tags;
        }

        public async Task<Tag> GetTagAsync(int id)
        {
            Tag tag1 = null;
            HttpResponseMessage response = client.GetAsync("Api/Tags/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                tag1 = JsonConvert.DeserializeObject<Tag>(resp);
            }
            return tag1;
        }

        public async Task<Uri> AjoutTagAsync(Tag tag)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("Api/Tags", tag);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public async Task<Uri> ModifTagAsync(Tag tag)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("Api/Tags/" + tag.Id, tag);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


        public async Task<Uri> SupprTagAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("Api/Tags/" + id);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public async Task<ICollection<Exhibit>> GetExhibitsAsync()
        {
            ICollection<Exhibit> exhibits  = new List<Exhibit>();
            HttpResponseMessage response = client.GetAsync("Api/Exhibits/").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                exhibits  = JsonConvert.DeserializeObject<List<Exhibit>>(resp);
            }
            return exhibits ;
        }

        public async Task<Exhibit > GetExhibitAsync(int? id)
        {
            Exhibit exhibit = null;
            HttpResponseMessage response = client.GetAsync("Api/Exhibits/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                exhibit  = JsonConvert.DeserializeObject<Exhibit>(resp);
            }
            return exhibit;
        }

        public async Task<Uri> AjoutExhibitAsync(Exhibit exhibit )
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("Api/Exhibits", exhibit );
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public async Task<Uri> ModifExhibitAsync(Exhibit exhibit )
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("Api/Exhibits/" + exhibit .Id, exhibit );
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


        public async Task<Uri> SupprExhibitAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("Api/Exhibits/" + id);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public async Task<ICollection<Area>> GetAreasAsync()
        {
            ICollection<Area> areas  = new List<Area >();
            HttpResponseMessage response = client.GetAsync("Api/Areas/").Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                areas  = JsonConvert.DeserializeObject<List<Area >>(resp);
            }
            return areas ;
        }

        public async Task<Area> GetAreaAsync(int? id)
        {
            Area area  = null;
            HttpResponseMessage response = client.GetAsync("Api/Areas/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var resp = await response.Content.ReadAsStringAsync();
                area = JsonConvert.DeserializeObject<Area >(resp);
            }
            return area;
        }

        public async Task<Uri> AjoutAreaAsync(Area area)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("Api/Areas", area);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public async Task<Uri> ModifAreaAsync(Area area)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("Api/Areas/" + area.Id, area);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


        public async Task<Uri> SupprAreaAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync("Api/Areas/" + id);
                response.EnsureSuccessStatusCode();
                return response.Headers.Location;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }



    }
}