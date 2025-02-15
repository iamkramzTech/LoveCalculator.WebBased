# Love Calculator – Web Based

## Overview  
The **Love Calculator** is a fun web based application built using ASP.NET Core MVC that calculates compatibility between two people based on their names. The app provides a playful percentage score and a quote message based on the result.  

## Caution  
- This app is for entertainment purposes only. The results should not be taken seriously.  
- Do not use this tool for making real-life relationship decisions.  

## User Guide  

### How to Use  
1. Open the website in your browser.  
2. Enter your name and partner's name in the input fields.  
3. Click the "Calculate Love" button.  
4. View the compatibility percentage and the generated message.  

### Features  
- Simple name-based love calculation    
- Fun and engaging UI  
- Responsive design for mobile and desktop users  

## Developer Guide  

### Prerequisites  
Ensure you have the following installed:  
- [.NET SDK](https://dotnet.microsoft.com/download) (8.0.13 or latest)  
- Visual Studio 2022
- Project Target Framework .net8.0

### Installation & Setup  
1. Clone the repository:  
   ```sh
   git clone https://github.com/iamkramzTech/LoveCalculator.WebBased.git
   cd love-calculator
Install dependencies:
dotnet restore  
Run the application:
dotnet run  
Open http://localhost:<your_port_number> in your browser.

Folder Structure
```
/LoveCalculator.WebBased  
│── Controllers  
│   ├── HomeController.cs  
│  
│── Views  
│   ├── Home  
│   │   ├── Index.cshtml  
│   ├── Shared  
│   │   ├── _Layout.cshtml  
│   ├── _ViewImports.cshtml
│   ├── _ViewStart.cshtml
│
│── Models  
│   ├── LoveCalculatorModel.cs  
│  
│── wwwroot  
│   ├── css  
│   ├── img 
|   ├── js
│  
│── appsettings.Development.json
│── appsettings.json    
│── Program.cs  
```
## Website Deployment
 - Love Calculator is deployed at: [https://github.com/iamkramzTech](https://github.com/iamkramzTech)

## Technology used
- Front-end : HTML, CSS, JavaScript
- Back-end : C#, ASP.NET Core MVC
- Hosting : MonsterASP.NET free plan

## Screenshots
