# Shoot The Enemies - My Changes
 
itch.io link: https://barakam.itch.io/shoot-the-enemies

The scene changed is under Assets/Scenes/4-levels/level1.

The script changed is under Assets/Scripts/2-spawners/KeyboardSpawner.cs.

The changes are:
* The player can't shoot non-stop. he has to wait 2 seconds between the shots.

* After 10 seconds the player gets the power of non-stop shots for 3 seconds.
  
  As long as the power is not over:
   * A yellow cannon appears on the spaceship.
   * their is a caption "hold for power".
  
  After the power runs out, the shooting returns to normal and the clocks reset.
  

# Unity week 2: Formal elements - Original Readme

A project with step-by-step scenes illustrating some of the formal elements of game development in Unity, including: 

* Prefabs for instantiating new objects;
* Colliders for triggering outcomes of actions;
* Coroutines for setting time-based rules.

Text explanations are available 
[here](https://github.com/erelsgl-at-ariel/gamedev-5782) in folder 04.

## Cloning
To clone the project, you may need to install git lfs first (if it is not already installed):

    git lfs install 

To clone faster, you can limit the depth to 1 like this:

    git clone --depth=1 https://github.com/<repository-name>.git

When you first open this project, you may not see the text in the score field.
This is because `TextMeshPro` is not in the project.
The Unity Editor should hopefully prompt you to import TextMeshPro;
once you do this, re-open the scenes, and you should be able to see the texts.



## Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)
