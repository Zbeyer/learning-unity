# learning-unity
This is a public repository for small sample Unity projects. It is intended to server as a collective reference for new Unity developers. All contents exist as 'work in progress.' When adding to this repository, please include references and links to supporting content, code snippets, or relavent tutorials. Please do not violate license agreements with borrowed or purchased assets. Honor the intellectual property of your peers.

### Please keep the root directory clean
The folder structure is organized as project folders. Each folder within the root is a standalone project. Please keep it tidy.

### Reccomended Trello for small project management
https://trello.com/

### .gitignore suggestions (to be added for each sub-project)
```
{project-folder}/Temp/**
{project-folder}/Library/**
{project-folder}/Obj/**

*.csproj
*.unityproj
*.sln
*.user
*.userprefs
*.DS_store
```
May want to try wildcards, see if it helps
```
**/Library/
**/Obj/
**/Temp/
```
Some additional notes: http://answers.unity3d.com/questions/1071723/unity-git-ignore-library.html
```
#For Mac developers
 # Unity generated #
 # =============== #
 Temp/
 obj/
 Build
 Library/
  
 
     # ===================================== #
     # Visual Studio / MonoDevelop generated #
     # ===================================== #
     ExportedObj/
     *.svd
     *.userprefs
     *.csproj
     *.pidb
     *.suo
     *.sln
     *.user
     *.unityproj
     *.booproj
     *.orig
     *.app
     *.exe
     *.*_data
     
     Build/iOS
     Build/android
     
     *.[od]
```
