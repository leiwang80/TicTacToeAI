This is a window application coded in c#/.net.  The executable is TicTacToe.exe located in debug/bin/.

This game can be played by two players or just one player playing with AI (artificial intelligence).  
The AI will support several difficulty levels.

Each level builds on top of the previous levels, thus, if the added behavior does not apply, then they would choose randomly.
Level 1 - AI will randomly choose their next move.
Level 2 - AI will block the player if their next move would win the game.
Level 3 - AI will recognize a winning move and will try to win the game.
Level 4 - AI places higher value on corner and center spots, only taking sides to win/block.
