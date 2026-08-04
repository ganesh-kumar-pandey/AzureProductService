Session 20-07-2026


Concept of Fatty Controller
----------------------------

 
1. MediatR Pattern.

2. CQRS Pattern

3. Dynamic Migration

4. Fluent Model Validation

5. FluentAPI

6. Onion Architecture 

7. Auto Mapper

8. Continuous Integration/ Continous Deployement

    A. Using Github Actions 
    B. Devops
    C. Secure Connection String using Azure Key Vault

26-July-2026
---------------------
Key Feture for implementing CICD
--------------------
1. key Vault
2. SQL Server(Azure)
3. nUnit Test Case
4. DevOps(CICD)
5. gitHub Actions(CICD)
Server Username: sqlserverdbsagkpdmin
Password : Gkp@15355
ConnectionString: Server=tcp:productdbs-server-gkp.database.windows.net,1433;Initial Catalog=productdbs-gkp;Persist Security Info=False;User ID=sqlserverdbsagkpdmin;Password=Gkp@15355;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

-------------------------------------------------------------------------------
30-July-2026
-------------------
Dotnet core   key vault----Manage Identity--->sqlserver(old way{app registration})  
Steps for accessing the key vault 
1. https://productservice-kv-gkp.vault.azure.net/ (key vault URI)
2. what kind of configuration is required for key vault in program.cs?
Packages:
---------- 
<PackageReference Include="Azure.Identity" Version="1.21.0" />
<PackageReference Include="Azure.Extensions.AspNetCore.Configuration.Secrets" Version="1.5.1" />


31-July-2026
-------------------
So, Key Vault = Config + Encryption + Hashing + Logging + Access Control + Rotation

04-August-2026
---------------------
1. Devops
2. gitHub
3. agent
4. pull on Github
5. Devops classic Architecture
6. Azure Appservice
devopsapiservicecicd-dxdzchb9eegnbfa7.centralindia-01.azurewebsites.net

Github Steps
-----------------
echo "# AzureProductService" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/ganesh-kumar-pandey/AzureProductService.git
git push -u origin main
