using System;

public class Restaurant
{
	public string id { get; set; }
	public string name { get; set; }
	public string stars { get; set; }
	public IEnumerable<string> categories { get; set; }

	public Restaurant()
	{
		
	}
}
