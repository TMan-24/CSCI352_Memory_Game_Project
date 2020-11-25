# CSCI352_Memory_Game_Project

Authors: Tony Anderson & Vrushank Mali
Last date modified: 11/24/2020
Course: CSCI 352
Project name: Memory Game

***WELCOME TO READ-ME***


Description:-

    This is a Memory game. It shows some pictures which you have to remember and then find and match them in time and finish or solve the game.
    This game is to sharpen your memoey and to know how well you can remember things. It is just for entertainment.


How it works:-

    As you start the game, it shows the start menu with three difficulty options:
          Easy
          Normal
          Hard
    
    You choose one of the difficulty level and start playing the game.
    
    As soon as you choose difficulty level and start playing, the time starts ticking.
    
    It shows time, score, music button, and pause button on screen with some photos.
    
    Based on your difficulty level, it shows some photos for five seconds and then they all get hidden and the you have to find and match them before the time limit ends.
    
    Based on how you play, it shows different screen ahead. For instance, if you finish the game in time, it shows the winning screen or loser screen.
    
    The winning screen shows your score with a button which takes you back to the start menu.
    
    The loser screen shows your score with two buttons, one which lets you restart the game with same difficulty and another whoch takes you back to the start menu.
    
    The pause screen shows three buttons:
          Resume  -   Basically resumes the game.
          Restart -   Restarts the whole game with same difficulty level.
          Quit    -   Ends the game and takes ypu back to the start menu.
          
    This is all the whole game. It is fully functional and you can play it.


Trials and Tribulations:-

    We had great difficulty implementing setting up time, background music, and photos. Even UML was really difficult, and confusing too.
    We didn't used any Design Patterns because they were difficult to understand and we both have difficulty implementing it since beginning of the semester.
    Another tribulation was to make them match correctly and then make them disappear from the screen.


Bugs and Future plans:-

    There is a bug in the game. It is the time countdown bug. Everytime you pause game and then resume it, the time starts countdown by +1 increment.
    For example, initially it was doing like this, which is 65....64....63....62.... and so on. Then, you pause the game and then resume it. Now, the time will tick like this,
    62....60....58....56.... and so on. Then you again pause the game and then resume it, then the time tick down with +1 increment, which is 56....53....50....47....and so on.
    This is the bug or you can call it a feature if you want to make your game more thrilling and difficult. But, we don't know how to solve it or where we did mistake.
    
    The pcitures in the game are static thus, ramdomizing pictures is the future plan.
    
    Another future plan is showing high score if someone scores more but for that there will be different types of calculations.
    
    Sound effect on hitting the buttons and solving the time countdown bug are also the future plans.
    
    
Questions and Feedback:-
    
    For any queries/questions and feedback, contact us below:
        Tony Anderson:  antgande@ut.utm.edu
        Vrushank Mali:  vrujmali@ut.utm.edu
    

***THANK YOU FOR READING ME.***
