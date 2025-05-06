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

## "Swap settings with old profile"

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


## Descripción
Spookz ARMA 3 Settings Swapper es una herramienta diseñada para simplificar el proceso de transferir configuraciones de un perfil antiguo de ARMA 3 a uno nuevo. Automatiza el proceso, porque sabemos que todos somos un poco perezosos.

## Características
- Soporta los siguientes archivos de perfil de ARMA 3:
  - `3den.Arma3Profile`
  - `.vars.Arma3Profile`
  - `.Arma3Profile`
- Asegura la codificación y decodificación adecuada de los nombres de perfil.

## Instrucciones de Configuración
No se requiere configuración. Simplemente ejecuta la aplicación.

## Uso
**PASO 1:**  
Primero, selecciona el perfil del cual deseas extraer las configuraciones en "Select the profile folder with your old settings".

**PASO 2:**  
Selecciona una acción:

Hay DOS botones:

- "Swap settings with old profile"
O
- "Create a new Profile"

## "Swap settings with old profile"

"Swap settings with old profile" necesita una carpeta de perfil previamente creada, ~~esto NO funcionará si la carpeta fue creada por ARMA 3, porque el programa aún no tiene la lógica para eliminar configuraciones antiguas del perfil. (PRÓXIMAMENTE). Puedes crear una carpeta y debes nombrarla usando un nombre codificado en HTTP que puedes obtener creando un perfil en ARMA 3, luego saliendo del juego, luego eliminando TODOS los archivos dentro de la carpeta del perfil y LUEGO usando esta herramienta.~~ Corregido, ahora puedes usar una carpeta creada por ARMA 3 ya que la herramienta eliminará los archivos antiguos.

Después de seleccionar la carpeta de perfil a la que deseas transferir tus configuraciones, verás dos campos abajo, IZQUIERDA será el nombre codificado y DERECHA será el nombre decodificado, esto no tiene otro propósito más que asegurarte de que estás seleccionando la carpeta correcta.

Después de seleccionar la carpeta y asegurarte de que está vacía, puedes presionar PROCEED.

## "Create a new Profile"

"Create a new Profile" no necesita una carpeta de perfil previamente creada y la creará por ti. Necesitas ESCRIBIR en el cuadro IZQUIERDO el nombre que deseas para tu perfil. NO TOQUES EL CUADRO DE TEXTO DERECHO, ya que este es el nombre codificado y si cambias el texto, estropearás la generación de la carpeta (y ARMA 3 no detectará tu carpeta de perfil, tal vez...). Una vez que hayas escrito el nombre que deseas para tu perfil, lo único que queda es hacer clic en PROCEED.

**PASO 3:**  
¡Haz clic en Proceed! Se te mostrará una advertencia primero, presiona 'Yes' si deseas continuar, por favor LEE la advertencia. Una vez que presiones Yes, si seleccionaste "Swap settings with old profile", aparecerá "Ye!" y luego, después de presionar Yes, aparecerá un mensaje notificándote si el intercambio se realizó o no.

Si seleccionaste "Create a new Profile", después de "Ye!" se te pedirá que selecciones una carpeta, SELECCIONA: "Arma 3 - Other Profiles", de lo contrario, la carpeta del perfil terminará donde hayas elegido. (POR CORREGIR), después de seleccionarla, aparecerá un mensaje notificándote si el intercambio se realizó o no.

## Tecnologías
- Codificador y decodificador HTTP personalizado.
- Construido usando WPF y .NET 8.

## Contribuidores
- **Spookz**
