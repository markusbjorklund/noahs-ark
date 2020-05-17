# Noahs ark #
_**Noahs ark** is the final project in our course Software Development tools. This CI pipeline exercise is done in our school Centria in Jakobstad, where we are the first students to be educated to junior developers in **Road to software engineering**. Our training started in January 2020 and will continue until December 2020. Due this pandemic covid-19 we're doing our school remotely this spring and hope we can meet in school again this fall._ 

_We have been five students working on this exercise. Our group is called **3#** and the members are: **Md Al Amin, Markus Björklund, Anna Isokoski, Petrina Lindqvist and Janne Nylund**._
_ _ _
#### How the program works: ####
This program consists of a UserInterface where you can try out all the animals. The program lists all the animals that have been created. You can ask for which animal to see and what you want the animal to do.

We have **wild** and **tame** animals. 

## WILD
 ![wolf](https://github.com/markusbjorklund/noahs-ark/blob/master/assets/wolf.jpg)
 
**Wild** animals are **tiger**, **wolf** and **bear** and they can:  
* Make sound
* Hunt (if an animals hunt is succeeded the animal gains 1kg of weight.)
## TAME
![dog](https://github.com/markusbjorklund/noahs-ark/blob/master/assets/max.jpg)

**Tame** animals are **bird**, **cat**, **dog** and **horse** and they can: 
* Talk to the owner
* Make sound
* Come to the owner
* Eat (an animal gains 1kg in weight when eating.)
_ _ _ 

#### Class diagram: ####
In this **class diagram** we have an abstract class called **Animal** with the method _Makesound_. The animals **cat, dog, bird** and **horse** with methodes _Eat, TalkToOwner, MakeSound_ and _ComeHere_ inheritates **ITame**. All the animals have a _weight_ and you can give them a _name_. The animals **bear, tiger** and **wolf** with methodes _Hunt_ and _MakeSound_ inheritates **IWild**. Wild animals also have a _weight_. Both Itame and IWild are using the interface **UserInterface**.

![class](https://github.com/markusbjorklund/noahs-ark/blob/master/assets/classdiagram.png)
_ _ _

#### Sequence diagram ####
In the sequence diagram you can see how the program works. In the diagram we have included just one tame animal and one wild animal because the function is the same for all the other animal types.

When you first run the program you are greeted with a welcome message and affer that you have the option to choose between a total of seven animals. This is the main startpoint for the program and also point to which we can refer to. Everytime you want to choose a new animal this is where you end up.

As stated earlier in the readme file there is a small difference between how the tame versus wild animals behave but all the tame animals need to have a name before you can make them do anything.

We also see a frequent use of the Console Clear command in the diagram and that is called to make the user experience more enjoyable and not clutter the whole terminal window.

When done with the program and the user wants to quit, we are not doing it by breaking a loop. Instead we are using a global exit command.

![sequence](https://github.com/markusbjorklund/noahs-ark/blob/master/assets/sequence_dia.png)
_ _ _

#### Folder structure ####
This image represents a scaled down folder structure of the files used in our program. The files in assets folder are not shown in this image but that is where for example this file is.

![tree](https://github.com/markusbjorklund/noahs-ark/blob/master/assets/folder-structure-user-friendly.png)

_ _ _

If you are interested in how we progressed with adding files, building the program and extending it you are welocmed to check out our board in Trello. You can find it here [here](https://trello.com/b/a4C3DPrX/3sharp).

 