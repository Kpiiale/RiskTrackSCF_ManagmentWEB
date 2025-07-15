# RiskTrackSCF - Panel de Administración Web

## Descripción

**RiskTrackSCF_ManagmentWEB** es la aplicación frontend del ecosistema **RiskTrackSCF**. Se trata de un Panel de Administración (dashboard) construido con **Blazor**.

Esta aplicación proporciona la interfaz de usuario para interactuar con los servicios de backend, permitiendo a los administradores gestionar el sistema de forma visual. Consume los endpoints de la API REST `RiskTrackSCF_UserCreatorAPI` para realizar operaciones como autenticación, creación y consulta de datos.

## Requisitos Previos

*   **.NET SDK** (se recomienda .NET 6.0 o superior).
*   Un navegador web moderno (Chrome, Firefox, Edge, etc.).
*   Tener la API de backend (`RiskTrackSCF_UserCreatorAPI`) en ejecución para que la aplicación frontend pueda conectarse a ella.

## Instalación y Ejecución

1.  **Clona el repositorio:**
    ```bash
    git clone https://github.com/Kpiiale/RiskTrackSCF_ManagmentWEB.git
    cd RiskTrackSCF_ManagmentWEB
    ```

2.  **Configura la aplicación:**
    *   Busca el archivo de configuración de la aplicación.
        *   Si es **Blazor Server**, será `appsettings.json`.
        *   Si es **Blazor WebAssembly**, será `wwwroot/appsettings.json`.
    *   Modifica los valores de configuración según la guía que se detalla en la siguiente sección.

3.  **Ejecuta la aplicación desde la terminal:**
    ```bash
    # Restaura las dependencias del proyecto
    dotnet restore

    # Inicia la aplicación en modo de desarrollo
    dotnet run
    ```
    Una vez iniciada, la aplicación estará disponible en la URL especificada en `Properties/launchSettings.json` (generalmente `http://localhost:5001` o `https://localhost:7001`).


