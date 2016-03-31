# Match Tracker
## Third Year Mobile Apps Project

This is my third year project for mobile apps development module. 

This is a universal app for the windows store. It can run on many platforms such as Windows 10 and Windows Phone.
Find out more about universal apps here:
https://msdn.microsoft.com/en-us/windows/uwp/get-started/whats-a-uwp

I chose this project because i love sport and wanted to make a sports based APP and to display my knowledge of local storage, Localisation, GPS Usage, Data binding, use of layouts and my general coding skill in C#.

I have designed this app to be simplistic to use for the user and have an attractive layout.

This app lets the user modify team names and scores as they are watching a Match(Gaa or Soccer) and save the results to local storage on their device.

Users can them view results(listView) and delete them as they wish.

This app also has the ability to store stadium names and coordinates of where the user is sitting if they wish to do so.
The user can view and delete the data.

##TECHNOLOGIES USED:

###local storage:

Files are stored in the devices local storage and files are appended to (Store data) and parsed (Retrieve data). 
Files are .txt files

###Localisation:

I have deStringifyed the App the include Language Support for English (en-GB, en-US) and Irish (ga).

###GPS Usage:

I have used GPS to store the location of your seat and stadium name.
Stadium name and seat longitude and latitude are save to a file and can be viewed in a ListView

###Data binding:
 
All of my results are an individual object in an ObservableCollection
I have used data binding to view the results in a listview on the results page for each sport.
Data binding allow me to have an individual tapped event for each result.

###Layouts:

I have used a simple but effective layout that automatically adjusts to the size of the screen to support cross platform universal app.
The layout is user-friendly, simple to read and understand with large buttons and text.


##Link to Match Tracker App in Windows store:
