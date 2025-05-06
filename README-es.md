
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