using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    private string[,] blocks = {
        //////////////////// 0
        {
         "Greetings, Player!",
        "Welcome to my game... no, welcome to my masterpiece.",
        "My magnum opus.",
        "What you are now immersed in is no mere ‘puzzle game’",
        "but the purest expression of the ideal puzzle.",
        "It has everything you could need in a good puzzle!",
        "A bridge! A key! A door! A box!",
        "Let me tell you how to play my game!",
        "It’s very simple, all you have to do is lower the bridge",
        "pick up the key, use the key to open the door, push the box out of the room",
        "across the bridge, and onto the button. Then you win! Hooray!"
        },
        //////////////////// 1
        {
            "Now, push the box onto the button!",
             "You’re nearly there now. Aren’t you excited?",
             "Can’t you feel the anticipation?",
             "Every moment building up to this.",
             "",
             "",
             "",
             "",
             "",
             "",
             ""
         },

        //////////////////// 2
         {
         "YES!!!! YOU DID IT! I’m so proud of you, Player!",
        "You’ve EARNED that confetti.",
        "Although… is it really enough to experience such a wonderful game only once?",
        "Did you really appreciate it? Savor it?",
        "Oh, I know! Let’s play it again! ",
        "",
        "",
        "",
        "",
        "",
        "",
        },
         //////////////////// 3
        {
        "Ah, welcome back Player! Couldn’t help but play again huh?",
        "And who could blame you!",
        "You get to experience all that thrill and exhilaration again.",
        "What could have more “value” than that?",
        "Other games might make you come up with another way to solve the same puzzle.",
        "But remember, MY game isn’t like other games.",
        "There’s only one solution: the correct one. ",
        "",
        "",
        "",
        "",
        },
        //////////////////// 4
        {
        "Huh? Wait a minute.",
        "You just stood on the button? That’s...not right. ",
        "No, that’s not right at all!",
        "Where’s the key? Restart the game I’ll fix that for you.",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        },
                //////////////////// 5
        {
        "Here we are! This should be easy enough.",
        "I’ve put the button right next to the box, all you have to do is unlock the door and push it on.",
        "Go on, Player! And don’t worry about last time, we all make mistakes sometimes. ",
        "Well. Most of us. ",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        },
                //////////////////// 6
        {
        "Aaaand!",
        "… ????",
        "Huh? That... should have opened the door to the flagpole. ",
        "You didn’t break anything did you?",
        "I forgot to make the button work. ",
        "One second Player, if you could just wait for me to fix this, it should only take a minute. ",
        "Don’t touch any of the doors.",
        "The key works on all the doors in this game, so it shouldn’t be a problem. ",
        "",
        "",
        "",
        },
                //////////////////// 7
        {
        "And if I just do this then it should—",
        "What? You did it? But...the button!",
        "Player I thought I told you to stay put.",
        "And look at what you’ve done, you’ve solved my puzzle the wrong way again!",
        "How did you even manage that?",
        "You used the key on the exit door?",
        "That’s the dumbest thing I’ve ever heard! Box puzzles are the simplest and most ",
        "beautiful kind of puzzles!",
        "Using a key to unlock a door isn’t a puzzle at all, we do that all the time in real life.",
        "Restart the game, I’ve fixed your little exploit.",
        "",
        },
                //////////////////// 8
        {
        "All right. I’ve taken away the bridge so you can’t get to the key.",
        "Not until I’ve fixed this dang button. ",
        "There’s nothing you can use on this side of the chasm so don’t even try! ",
        "I’ve even filled the chasm with spikes! Good luck getting over that!",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        },
                //////////////////// 9
        {
        "Argh! NO!",
        "The spikes are supposed to STOP you.",
        "You’re being such a jerk you know?",
        "I worked hard on this puzzle, and it’s better than anything YOU could ever make. ",
        "I don’t like this game you’re playing with me, Player. ",
        "Because it’s not MY game!!",
        "Who’s the developer here, huh? You or me?",
        "That’s right, it’s me! So let me do my job, and you do yours!",
        "Okay?",
        "Whew...alright. ",
        "Sorry. Let’s try this one more time.",
        },
                //////////////////// 10
        {
        "Ok, I’m going to leave you out here so DON’T. MOVE. ",
        "I can’t edit the game unless we’re on this screen",
        "so you just have to let me do what I do best okay?",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        },
                //////////////////// 11
        {
        "NO! No, no, no!",
        "NO you did not “do it,” you don’t deserve this win screen! ",
        "That crown should say “idiot” on it, because that’s what you are! ",
        "A #1 idiot!!",
        "That wasn’t even a puzzle! You just walked over and clicked on it!! ",
        "You are the meanest, stupidest, WORST Player I’ve ever met.",
        "You have NO respect for art!",
        "“Dur duh I’m the Player, I wanna touch the shiny flagpole”",
        "Why don’t you play like I want you to?",
        "You think you know better than ",
        "me, don’t you. Well fine! Let’s do what YOU want!",
        }


        };  
    public float typingSpeed;

    public void Start()
    {
    }
    
    public void playDialogueChunk(string[] s)
    {
        StartCoroutine(Type(s));
    }
    
    IEnumerator Type(string[] sentences) {
            
        int index = 0;
        
        while(index < sentences.Length - 1){
            
            foreach(char letter in sentences[index].ToCharArray()) {
                textDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }

            yield return new WaitForSeconds(3);
            
            index++;
            textDisplay.text = "";
        }
        textDisplay.text = "";
    }
        
}