# Spookz ARMA 3 Settings Swapper

## Description
Spookz ARMA 3 Settings Swapper is a tool designed to simplify the process of transferring settings from an old ARMA 3 profile to a new one. It automates the process, because I know we all are lazy like that.

## Features
- Supports the following ARMA 3 profile files:
  - `3den.Arma3Profile`
  - `.vars.Arma3Profile`
  - `.Arma3Profile`
- Ensures proper encoding and decoding of profile names.

## Setup Instructions
No setup is required. Simply run the application.

## Usage
**STEP 1:**  
First, select the profile from which you want to extract the settings on "Select the profile folder with your old settings".

**STEP 2:**  
Select an action:

There is TWO buttons:

- "Swap settings with old profile"
OR
- "Create a new Profile"

##Swap settings with old profile

"Swap settings with old profile" need a previously created profile folder, ~~this will NOT work if the folder was created by ARMA 3, because the program still does not have the logic to delete old profile settings. (SOON TO BE ADDED). You can create a folder and you need to name it using an HTTP Encoded name which you can get by creating a profile in ARMA 3, then quitting the game, then deleting ALL the files inside the profile folder and THEN using this tool.~~ Fixed, you can now use an ARMA 3 created folder as the tool will delete the old files.

After selecting the profile folder you want to transfer your settings to, you will see two fields below, LEFT is going to be the encoded name and RIGHT will be decoded name, this serves no purpose other than letting you know you're selecting the right folder.

After selecting the folder and making sure it's empty, you can press PROCEED.

## "Create a new Profile"

"Create a new Profile" doesn't need a previously created profile folder and it will create it for you. You need to TYPE on the LEFT box the name you want for your profile. DO NOT TOUCH THE RIGHT TEXT BOX, as this is the encoded name and if you change the text you will fuck up the folder generation (and ARMA 3 will not detect your profile folder, maybe...) Once you have typed out the name you want for your profile, all that's left is that you click PROCEED.

**STEP 3:**  
Click Proceed! You will be prompted a warning first, press 'Yes" if you wish to continue, please READ the warning. Once you press Yes, if you selected "Swap settings with old profile", "Ye!" will appear and then after you press Yes, a prompt will appear, notifying if the swap was done or not.

If you selected "Create a new Profile", you will be prompted after "Ye!" to select a folder, SELECT: "Arma 3 - Other Profiles" otherwise the profile folder will end up wherever you've chosen. (TO BE FIXED), after you select it, a prompt will appear notifying you if the swap was done or not.

## Technologies
- Custom HTTP encoder and decoder.
- Built using WPF and .NET 8.

## Contributors
- **Spookz**