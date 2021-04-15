using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema
using System.ComponentModel.DataAnnotations;

public class CelestialObject
{
	public CelestialObject()
	{
	}

	public int Id;

	[Required]
	public string Name;

	public int OrbitalObjectId;

	[NotMapped]
	public List<CelestialObject> Satellites;

	public TimeSpan OrbitalPeriod;
}
