using System.Collections.Generic;
using MySqlConnector;
using System;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string ServiceHistory { get; set; }
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}