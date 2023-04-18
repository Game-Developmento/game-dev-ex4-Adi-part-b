# Jumper Frog Game

## Gameplay

Jumper Frog is a game where the player must guide a frog across a busy street while avoiding cars. The goal is to reach the other side of the street without colliding with any cars.

## Requirements

The game was built using Unity version `2021.3.18f1`.

## Rules & How to Play

1. Visit the Jumper Frog game page in your web browser.
2. Use the arrow keys (left, right, up, and down) to move the frog.
3. If the player reaches the footpath, the game will display a message that they are a winner.
4. Colliding with a car will result in the game ending, and the player will need to start over from the beginning.

## Scenes, Scripts, and Prefabs

Jumper Frog was developed using Unity version 2021.3.18f1 and features multiple prefabs, scripts, and scenes that make up the game.

### Scenes

1. `JumperFrog`: This is the main game scene where the player controls the frog and avoids cars.
2. `Winner-Scene`: This scene is loaded when the player successfully reaches the footpath and wins the game.

### Scripts

* `Mover`: This script is used to move the cars.

* `Input Mover`: This script is used to move the frog (player) in response to user input.

* `TimedSpawnerRandom`: This script is used to respawn cars at random intervals.

* `BorderCollision2D`: This script is used to ensure that the player stays within the game borders.

* `DestroyOnTrigger2D`: This script is used to destroy cars when they collide with the player.

* `GoToNextLevel`: This script is used to load the winner scene when the player reaches the footpath.

* `Replay`: This script is used for the replay button to restart the game.

* `SingletonByName`: This script is used to generate the player only once. This is useful so it stays in the same place when the next scene is loaded.

### Prefabs

Prefabs are pre-made game objects that can be duplicated and used throughout the game, making it easy to create and manage multiple instances of the same object. In Jumper Frog, prefabs include spawners, road asphalt, car designs, and footpath, among others.
