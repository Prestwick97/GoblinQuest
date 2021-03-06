using System;
using System.Collections.Generic;

namespace GoblinQuest.Models
{
  public class Quest
  {
    public static List<string> inventory = new List<string>();
    public string PlayerName{get; set;}
    public string Item{get; set;}

    public Quest(string playerName, string item)
    {
      PlayerName = playerName;
      Item = item;
    }

    public void ActOne()
    {
      Console.WriteLine("~Goblin Quest. Act One. The Missing.~");
      Console.WriteLine("The Second sun of Grobleon has set as the thrid rises. The dawn of the Goblin is nye.");
      Console.WriteLine("Awaken.");
      Console.WriteLine("You sit at the foot of your stone bed rubbing the sleep from your red and yellow eyes. You notice a disturbance. Faint at first, but growing.");
      Console.WriteLine("'Come Brak-Du, it is time for feeding.' Only silence responds.");
      Console.WriteLine("Your feline companion, Brak-Du has not heeded your call. This is a strange happening. For Brak-Du the Consumer, is ever loyal. ");
      Console.WriteLine("Your worries turn to fear. The wooden door to your small quarters has been damaged. Muddy footprints enter and leave your abode.");
      Console.WriteLine("'Froglok!' your Goblin fists pound against stone. You are filled with rage. The Froglok are foul beasts who are lothed by the Goblin clan of Gromleon.");
      Console.WriteLine("Your rage is replaced with sorrow. Your sorrow turns to hatred. 'Oh Loyal Brak-Du, Consumer of All.. Where art thou.. you must be found.. Nay. ....Avenged.");
      Console.WriteLine("Gather your courage young one. Welcome.. to..");
      Console.WriteLine("continue? (y/n)");
      string start = Console.ReadLine();
      if (start == "y")
      {

      
      Console.WriteLine(@" _______  _______  ______   _       _________ _                   _______           _______  _______ _________
(  ____ \(  ___  )(  ___ \ ( \      \__   __/( (    /|           (  ___  )|\     /|(  ____ \(  ____ \\__   __/
| (    \/| (   ) || (   ) )| (         ) (   |  \  ( |           | (   ) || )   ( || (    \/| (    \/   ) (   
| |      | |   | || (__/ / | |         | |   |   \ | |   _____   | |   | || |   | || (__    | (_____    | |   
| | ____ | |   | ||  __ (  | |         | |   | (\ \) |  (_____)  | |   | || |   | ||  __)   (_____  )   | |   
| | \_  )| |   | || (  \ \ | |         | |   | | \   |           | | /\| || |   | || (            ) |   | |   
| (___) || (___) || )___) )| (____/\___) (___| )  \  |           | (_\ \ || (___) || (____/\/\____) |   | | _ 
(_______)(_______)|/ \___/ (_______/\_______/|/    )_)           (____\/_)(_______)(_______/\_______)   )_((_)
                                                                                                              
 ______   _        _______  ______   _______                                                                  
(  ___ \ ( \      (  ___  )(  __  \ (  ____ \                                                                 
| (   ) )| (      | (   ) || (  \  )| (    \/                                                                 
| (__/ / | |      | (___) || |   ) || (__                                                                     
|  __ (  | |      |  ___  || |   | ||  __)                                                                    
| (  \ \ | |      | (   ) || |   ) || (                                                                       
| )___) )| (____/\| )   ( || (__/  )| (____/\ _                                                               
|/ \___/ (_______/|/     \|(______/ (_______/(_)                                                              
                                                                                                              
 _______  _______                                                                                             
(  ___  )(  ____ \                                                                                            
| (   ) || (    \/                                                                                            
| |   | || (__                                                                                                
| |   | ||  __)                                                                                               
| |   | || (                                                                                                  
| (___) || )_                                                                                                 
(_______)|/(_)                                                                                                
                                                                                                              
          _______  _______                                                                                    
|\     /|(  ___  )(  ____ \                                                                                   
| )   ( || (   ) || (    \/                                                                                   
| | _ | || |   | || (__                                                                                       
| |( )| || |   | ||  __)                                                                                      
| || || || |   | || (                                                                                         
| () () || (___) || (____/\ _                                                                                 
(_______)(_______)(_______/(_)   

 ");
      Console.WriteLine(@"                     ______
                  .-        -.
                 /            \
                |              |
                |,  .-.  .-.  ,|
                | )(__/  \__)( |
                |/     /\     \|
      (@_       (_     ^^     _)
 _     ) \_______\__|IIIIII|__/__________________________
(_)@8@8{}<________|-\IIIIII/-|___________________________>
       )_/        \          /
      (@           `--------` ");

      }
      GoblinVillage();

    }

    public void GoblinVillage()
    {
      Console.WriteLine("Continue your quest? (y/n)");
      Console.ReadLine();
      Console.WriteLine(@"	
      .......::::::::::::)..           .......................(::::::........
      .:::::;;;;;;;;):::::::.... .           .......:::::::::::::<......
          <  >>>                   ,.
  .::..  ;   I;L\  /L\.  ..::..   /iL.           |         ..::::::::::::..
        ;    II;L\/LLLL;         / I;L\    \     |     / /\_
             II;..LLLLLL\    _._/ I;:.L\     \   |   / _/J; \         
      :     IIIIi;..LLLLL\__/   IIII:..L\____  \###/  /JJI:  \     The Goblin Village.
    ,;     ILIi;;;:...:LLL;\      IIIII;.LLLLL\#####/JJ II;   \
   ;     I LLii;;;.:.. :LLL;\     III;;;::LLLLL\###/JJ IIII;   \_.
  :     IIILiii;;::.... :LLL;|      ;;I;;::.:LLLLLL:;IJ IIIII;:   \__.
           IIIII IIii;;::;..;\          ;;:::...LLLL;IJIII;;    :::   \
:    ;    IIIIIIIIIii;;::.;..      _==|      ;..  :;IJIII;:::    ::    \
    ;    ::::::::::::;;::..;  _==|   )__)  |                            \
 '  '`  `  ``'``'``  ``'`  '`    )_)  )___) ))  ``''`   ``'`  `'` `'`'`'  `'``
        '``   ``^^       ^~   )___) )____))_)   ~~         ``^^^``  '  `  `~`
' ^^            ^        _    )____)_____))__)\      ~^~~^           ^^`
     '^^          ^~      \---__|____/|___|___-\\--        `~`~         `~`
   ''    '^          ~`~   \   oo oo oo oo     /      ~`      '~       ``~`
        ____   ^^^`~   ~~^^^^^^^^^^^^^^^^^^^^^^    ^~^            ^~^^^
      /  o   \     ``'`  __          __ `'`''     '   ''~     ~``~``    ``''
    < ____     \`'`    /    \   `' /    \       _          _    `~    _
          |     |     |  __  |    |  __  |    /   \      /   \       / |
    '''   |_____|  '  |__||__| '' |__||__| ' |_____| '' |_____| ``  /_/
         '''     ~^^^^      '```^^'''''^        '''''''``        '''''^^``
   ''          '^^           ~^^~          ~^ '      ~~      '  ^   ^^^^^^^^
");
      Console.WriteLine("~ Act Two. The Villager. ~");
      Console.WriteLine("You exit your small Goblin home and make your way to the village square. Somone must have seen something suspicious.. Somone must have the answers you seek.");
      Console.WriteLine("You see the Village merchant selling its wares. Odds and ends mostly. They are known for their steep prices, and loose tongue.");
      Console.WriteLine("Would you like to approach the Villager? (y/n)");
      Console.ReadLine();
    Console.WriteLine(@"            
               _.------.
           _.-`    ('>.-````-.
 '.__.---'`       _'`   _ .--.)
       -'         '-.-';`   `
        ' -      _.'  ``'--. 
            '---`    .-'```
                   /`");
      Console.WriteLine("`Brrraaaaakkkkkkkkk` the Village merchant lets out a log caw. Its chipped beak shakes violently as it grooms its dark feathers.");
      Console.WriteLine("Villager: 'Braaaakkkk...What do you want adventurer? Braaaakkkkk! I have salt yes, spice from the Gro-Lok'thu clan, Braaakkkkk. See anything you like?'");
      Console.WriteLine("Select: (1) Have you seen anything suspicious? (2) Bribe to see secret wares");
      string response = Console.ReadLine();
      if (response == "1")
      {
        Console.WriteLine("Brrraaakkkk! Why yes I have! A wiley band of Froglok made way this night. Yes.. Up to no good they are!  Braaaakkkkk! Uncivilized beasts! Braaakkkk!! I heard them last night I did. Making their way into the dark Forest. They had a small prisoner.. Braaakkk!!! In a small cage!");
        Console.WriteLine("Would you like to pay for the information? Toss a coin? (y/n)");
        string response1 = Console.ReadLine();
        if (response1 == "y")
        {
        Console.WriteLine("'Don't tell me you're planning on going after them.... Braaaaakkkkk!!! The road is dangerous! Here. Take this.. Brraaaaakkk!");
        Console.WriteLine("The villager hands you a long wrapped package");
        Console.WriteLine("Behold.");
        Console.WriteLine(@"

                                                      )         
                                                        (                                
                                                      '    }      
                                                    (    '      
                                                   '      (   
                                                    )  |    ) 
                                                  '   /|\    `
                                                 )   / | \  ` )   
                  THE                           {    | | |  {   
               BLADE                           }     | | |  .
                OF                              '    | | |    )
              WOE.                             (    /| | |\    .
                                                .  / | | | \  (
                                              }    \ \ | / /  .        
                                               (    \ `-' /    }
                                               '    / ,-. \    ' 
                                                }  / / | \ \  }
                                               '   \ | | | /   } 
                                                (   \| | |/  (
                                                  )  | | |  )
                                                  .  | | |  '
                                                     J | L
                                               /|    J_|_L    |\
                                               \ \___/ o \___/ /
                                                \_____ _ _____/
                                                      |-|
                                                      |-|
                                                      |-|
                                                     ,'-'.
                                                     '---'");
        GoblinVillage2();
      }
      else
      {
        Console.WriteLine("Braaaakkk!! Information is not free! Go back to your home.. Braaaakkkk!!");
        GoblinVillage2();
      }
    }
  }
    public void GoblinVillage2()
    {
      inventory.Add("Sword");
      string sword = inventory[0];
      Console.WriteLine("Item obtained: "+sword+", Blade of Woe. +3 sapping damage.");
      Console.WriteLine("Seems like you've done all you can here. Would you like to exit the Goblin Village? Proceed to the Dark Forest? (y/n)");
      string journey = Console.ReadLine();
      if(journey == "yes")
      {
        Console.WriteLine("As you gather your things, you prepare for your journey to the Dark Forest.");
        ActTwo();
      }
      else 
      {
        GoblinVillage();
      }
    }

    public void ActTwo()
    {
      Console.WriteLine("~As you approach the shaded woods of the Dark Forest,you notice a series of frog-like footprints creating a muddied path through leading into the forest.~");
      Console.WriteLine("Follow the path? (yes/no)");
      string path = Console.ReadLine();
      if(path == "yes")
      {
        DarkForest();
      }
      else
      {
        GoblinVillage();
      }
    }
    public void DarkForest()
    {
      Console.WriteLine(@"         .        +          .      .          .
     .            _        .                    .
  ,              /;-._,-.____        ,-----.__
 ((        .    (_:#::_.:::. `-._   /:, /-._, `._,
  `                 \   _|``=:_::.`.);  \ __/ /
                      ,    `./  \:. `.   )==-'  .
    .      ., ,-=-.  ,\, +#./`   \:.  / /           . THE DARK FOREST.
.           \/:/`-' , ,\ '` ` `   ): , /_  -o
       .    /:+- - + +- : :- + + -:'  /(o-) \)     .
  .      ,=':  \    ` `/` ' , , ,:' `'--`.--`---._/`7
   `.   (    \: \,-._` ` + '\, ,`   _,--._,---`:.__/
              \:  `  X` _| _,\/'   .-'
.               `:._:`\____  /:'  /      .           .
                    \::.  :\/:'  /              +
   .                 `.:.  /:'  }      .
           .           ):_(:;   \           .
                      /:. _/ ,  |
                   . (|::.     ,`                  .
     .                |::.    {\
                      |::.\  \ `.
                      |:::(\    |
              O       |:::/{ }  |                  (o
               )  ___/#\::`/ (O `==._____   O, (O  /`
          ~~~w/w~`~~,\` `:/,-(~``~~~~~~~~`~o~\~/~w|/~
         ~~~~~~~~~~~~~~~~~~~~~~~\\W~~~~~~~~~~~~\|/~~");
      Console.WriteLine("~Sword at your side, you make your way down the dark and damp mud path through the Dark Forest...~");
      Console.WriteLine("~You hear a rustling noise behind you. Do you wish to investigate?~ (yes/no)");
      string rustle = Console.ReadLine();
      if (rustle == "yes")
      {
        
        Console.WriteLine("~As you turn your head, you see green flash in your perriferal...  With your swift goblin speed, you're able to grab hold of the mysterious blur... The creatue you've pinned to the forest floor is a lesser Froglok!~");
        Console.WriteLine("~Rage flows through you as you think if your beloved feline companion...~  Execute or question this creature? (execute/question)");
        string frog = Console.ReadLine();
        if (frog == "execute")
        {
          Console.WriteLine("You plunge your chipped scimitar into the gut of the lesser Froglok as you take your first sentient life....");
          Console.WriteLine("... As you roam through the Dark Forest, you continue to follow a series of muddied trails until....");
          FroglokCamp();
        }
        else{
          Console.WriteLine("You: `Where is he?! Where is my cat?!`");
          Console.WriteLine("Froglok: `Please dont hurt me! I swear I don't know what you're talking about! What is cat??`");
          Console.WriteLine("You: `Take me to your leader...`");
          Console.WriteLine("The lesser froglok leads you along a specific series of muddied paths. a clearing the the trees comes into sight.");
          FroglokCamp();
        }
      }
    }
    public void FroglokCamp()
    {
      Console.WriteLine("~Canvas tents, ladders, trees, and small fires come into view. As you get closer, you see all the other frogloks inhabitting their camp.~ ~How do you wish to enter?~");
      Console.WriteLine("Option one: Slowly walk into the camp with your sword against the back of your froglok hostage, demanding to speak to their leader.(one)");
      Console.WriteLine("Option two: Charge into the camp, slaying as many as you can in a blind rage.(two)");
      string camp = Console.ReadLine();
      if (camp == "one")
      {
        Console.WriteLine("~With your sword against the terrified Froglok's back, you demand to speak with their leader. ... All Froglok's freeze in place, petrified with fear for their brethren~");
        Console.WriteLine("~In the silence of terror, one larger Froglok covered in scars and jewels steps outside of his tent and walks toward you....~");
        Console.WriteLine(@"
                                      o  o   o  o
                                      |\/ \^/ \/|
                                      |,-------.|                  |
                                    ,-.(|)   (|),-.            O%%%%#============--    
                                    \_*._ ' '_.* _/                |
                                      /`-.`--' .-'\                     Froge.
                                ,--./    `---'    \,--.               Lord of the FrogLok.
                                \   |(  )     (  )|   /
                                 \  | ||       || |  /
                                  \ | /|\     /|\ | /            
                                  /  \-._     _,-/  \
                                  //| \\  `---'  // |\\
                                /,-.,-.\       /,-.,-.\
                                o   o   o      o   o    o");
        Console.WriteLine("`My name is King Frogue. What do you want, goblin. We have no qualms with your kind`");
        Console.WriteLine("Option one: `Where is my cat.. I know you took him.(one)`");
        Console.WriteLine("Option two: `Tell me where he is, or your freind dies.(two)`");
        string leader = Console.ReadLine();
        if (leader == "one")
        {
          Console.WriteLine("Frogue: `You must be speaking of the feline. You must destrpy it before it's too late. If you don't believe me, go to the mountains and learn for yourself.`");
        }
      }
    }
  }
}