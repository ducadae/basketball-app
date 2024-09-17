using System;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")] //api/Players

public class PlayersController(DataContext context) : ControllerBase //gives a default constructor that uses our DataContext class
{

  //This request returns all players
  [HttpGet]

  public async Task<ActionResult<IEnumerable<Players>>> GetPlayers()
  {
    var players = await context.Players.ToListAsync();
    
    return Ok(players);  //returns an action result which can have an HttpStatus attached to it
  }

  //This request returns an individual player
  [HttpGet("{id:int}")] //apid/users/id

  public async Task<ActionResult<IEnumerable<Players>>> GetPlayer(int id)
  {
    var player = await context.Players.FindAsync(id);

    if (player == null) return NotFound();
    
    return Ok(player);  //returns an action result which can have an HttpStatus attached to it
  }
}
