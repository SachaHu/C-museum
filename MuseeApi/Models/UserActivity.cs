﻿namespace MuseeApi.Models
{
    public class UserActivity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}