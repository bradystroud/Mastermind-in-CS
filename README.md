# MasterMind in C#
I recreated an [old board game](https://en.wikipedia.org/wiki/Mastermind_(board_game)) where Player 1 made a row of 4 coloured pins. Player 2 tried to guess the row as the Player 1 provided cryptic feedback on their guesses.
 
For example:
 
**Secret:** <br/>
`RED GREEN YELLOW BLUE`
 
**Guess:** <br/>
`RED RED YELLOW BLUE`

The feedback for this guess would be: </br>
`3 pins were the correct colour and in the correct place.`

---

**Secret:** <br/>
`RED GREEN YELLOW BLUE`
 
**Guess:** <br/>
`GREEN RED YELLOW BLUE`

The feedback for this guess would be: </br>
`2 pins were the correct colour and in the correct place,
one pin was the correct colour, but not in the correct place`