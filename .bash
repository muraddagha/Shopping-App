alias run-back="cd back-end/Api && dotnet watch run"
alias run-app="cd front/ && ng serve"
alias add-mg="dotnet ef --startup-project ../Api/Api.csproj  migrations add InitialCreation -p DataService.csproj -o Migrations"
alias up-db="dotnet ef --startup-project ../Api/Api.csproj database update -p DataService.csproj"
alias add-mg-c$cName="dotnet ef --startup-project ../api/api.csproj migrations add $cName -p data.csproj -o migrations"