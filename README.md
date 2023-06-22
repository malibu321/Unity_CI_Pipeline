# Unity_CI_Pipeline
A CI pipeline for Unity Projects, using [game.ci.](https://game.ci/)
 

This repository aims to provide a minimal boilerplate to start a working CI pipeline
with Unity, Git and GitHub.

## How to set up a CI pipeline a Unity project
### Requirements
#### Git and Git LFS (Large File Storage, needed for larger files)
If not already happened, download and install Git and Git LFS:<br> 
https://git-scm.com/<br>
https://git-lfs.com/

### Project Setup
#### GitHub Project
Create a new GitHub Project and clone it to your local device. 
Or use an existing git repository. 
#### .gitignore file
Create a Unity .gitignore file or use the one in this repository, 
for some additional ignores (pathes must be updated to your project)

#### Git LFS (Large File Storage)
Open the local GitHub project Folder with GitBash (installed with Git), or any other git command line and execute
git lfs install

Put the .gitattributes file of this repository in the git project root (where the .gitignore is) or create / use your own.
This file defines the larger files, which will be handles by the Large File Storage. If a project has other large file types which
are not defined in the file, they can become corrupted. 

Commit and push.

#### Unity Project
Move the Unity project folder into the repository folder or create a new Unity project inside.

Commit and push.

## Preparation
### 1. Retrieve Unity License File
Follow the steps for activation at https://game.ci/docs/github/activation <br>
It's not an error if the retrieved license files has Unity 2019 in it's name.<br>
The Unity version of the license file does not matter anymore. It works with every Unity version.

### 2. Set up GitHub Secrets
Go to GitHub project setting -> Secrets and variables -> Actions

Create 3 new repository secrets:<br>
UNITY_EMAIL : the email adress used with your unity account<br>
UNITY_PASSWORD: the password of your unity account<br>
UNITY_LICENSE: copy and paste the content of the retrieved Unity license file (the .ulf) from step 1.

![image](https://github.com/mavju/Unity_CI_Pipeline/assets/114022257/f2b3ca89-62e7-4a0b-8c02-1ffa013d10d3)

### Integration
Copy the main.yml under .github/workflows in this project to your own. Edit it, replace every "Unity-CI-Pipeline" (without the quotes) to your project name.
Comment / uncomment unwanted / wanted target platforms. Only StandaloneWindows64 was tested. 

### Usage
Now everytime the main branch has a new commit, the build workflow will start. The built binaries are zipped and can be downloaded at the workflow summary -> artifacts (if the build was successful).

See https://game.ci/docs/github/getting-started for further documentation of Game CI.



