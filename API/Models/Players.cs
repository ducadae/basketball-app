using System;

namespace API.Models;

public class Players
{
  public int Id { get; set; }
  public required string FirstName { get; set; }
  public required string LastName { get; set; }
  public required string MiddleName { get; set; }
  public required int Age { get; set; }
  public required int YearsPro { get; set; }
  public required int Height { get; set; }
  public required int Weight { get; set; }
  public string? College { get; set; }
  public required string Position  { get; set; }
  public string? SecondaryPosition { get; set; }
  public required string Handedness { get; set; }
  public required int ShotClose { get; set; }
  public required int ShotMed { get; set; }
  public required int ShotThreePoint { get; set; }
  public required int ShotLow { get; set; }
  public required int Layup { get; set; }
  public required int Dunk { get; set; }
  public required int FreeThrow { get; set; }
  public required int Passing { get; set; }
  public required int Dribbling { get; set; }
  public required int OffhandDribbling { get; set; }
  public required int OffensiveIQ { get; set; }
  public required int DefensiveIQ { get; set; }
  public required int LowPostTechnique { get; set; }
  public required int PerimeterDefense { get; set; }
  public required int PostDefense { get; set; }
  public required int HelpDefense { get; set; }
  public required int Steal { get; set; }
  public required int Block { get; set; }
  public required int DefReb { get; set; }
  public required int OffReb { get; set; }
  public required int Speed { get; set; }
  public required int Quickness { get; set; }
  public required int Vertical { get; set; }
  public required int Strength { get; set; }
  public required int Durability { get; set; }
  public required int Potential { get; set; }

}
