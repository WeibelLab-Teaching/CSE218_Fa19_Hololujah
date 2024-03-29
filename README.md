## Table of contents
* [Description](#Description)
* [Installation](#Installation)
* [Demo](#Demo)
* [Features](#Features)
* [Authors](#Authors)
* [Testing and Feedback](#Testing)
* [Thanks](#Thanks)
* [Technologies used](#Technology-Used)
* [Wiki](https://github.com/WeibelLab-Teaching/CSE218_Fa19_Hololujah/wiki)
## Description

### What is CookAR? 
<p align="center">
  <img width="460" height="460" src="https://i.imgur.com/IX35SDZ.png">
</p>
CookAR is a project aimed at providing a faster and better cooking experience for everyday lives. Essentially, this is done by using an open source cooking recipe database in the backend and a Unity Frontend. 

### Why CookAR? 
One-third of all food produced is wasted, and traditional challenges with cooking such as lack of recipes to select from, indecision on what to cook, dirty hands and distractions that can prove to be deadly still exist. Therefore, here we look at a way to alleviate these chaklenges by using a AR application used on the Microsoft Hololens I. 

The most important use of CookAR is reduction of time with finding an interesting/appropriate recipe and following traditional mediums of information for recipes.

### What does CookAR do?
CookAR helps reduces recipe lookup times by providing users with a range of recipe options that decreases the recipe selection time, using three different usecases:-

* Selecting a recipe while looking at the entire database of options
* Selecting a recipe using text based search, from this list to display to the user
* Providing the user with one random recipe to quickly cook 

Also, with each dish, once it is selected we have a interface that helps view instructions and a video to understand the process, and quickly make this recipe.

## Installation

All dependencies are related to MRTK and can be installed using [The MRTK Getting Started Page](https://microsoft.github.io/MixedRealityToolkit-Unity/Documentation/GettingStartedWithTheMRTK.html#prerequisites)

The right unity version can be selected [here](https://unity3d.com/get-unity/download/archive) for download as 2018.4.8


## Demo 
[![Demo video](https://i.imgur.com/IX35SDZ.png ) ](https://youtu.be/bmc1WXyR_zc) 

Click on the above icon to play the demo video for our project 

## Features

Select your favorite recipe using three modes:- 

 * 'Taste Palette' - Ideas and Inspiration when you're Lazy:- Check out the Taste palette if you ever run out of recipe ideas and to get a spread of recipes to check out. 
 * 'Surprise Me!' - Exciting and quick when you just need something to cook:- Just get a surprise recipe to cook. Adds to the suspense, and you can use this to get something arbitrary to cook
 * 'Search' - Targeted search when you have something in mind:- Use textboxes and search tags to get your recipe of choice 
 
 Also, as part of this application we support 100+ recipes with room for more
 
## Testing 

![Testing](https://i.imgur.com/alEG4HQ.png)

Also based on feedback during our demo presentation, we can add:- 
* cursor support to know where someone is clicking
* integration of the video with stepwise pause and play
* probable collaboration based applications

For more detailed information visit [the wiki page](https://github.com/WeibelLab-Teaching/CSE218_Fa19_Hololujah/wiki/Usability-Testing-and-Evaluation)

## Authors

* [Raghav Kalayanasundaram Subramanian](https://github.com/rksubram)
* [Dharmendra Chaturvedi](https://github.com/dheeru487)
* [Dan Xu](https://github.com/xudaaaaan)

## Thanks

Thanks to Tab Atkins for approving the use of this recipe database for our project!

## Technology Used

Mixed Reality Toolkit, Unity, Xanthir recipe database, JSONUtility

## Future work

Our app was succesful in terms of recipe lookup via one of the three scenes and the related application, for this. Particularly, our lookup times scale very well even with addition of new elements. Also, with our interface we found that the organization was very organic and easy to use towards development. 

1. Full integrated support for speech parsing 
2. Actual texture and cooking process related integration 

## Reference

We used some prefabs and positional aspects from the MRTK sample applications towards accelerating development here. 
