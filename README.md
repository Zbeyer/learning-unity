# learning-unity
A public repository of Unity projects

### Please keep the root directory clean
Repo organized by project folders. Each folder within the root repo is a standalone project. Please keep it tidy.

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
