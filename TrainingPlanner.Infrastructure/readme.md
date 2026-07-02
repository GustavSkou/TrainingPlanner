
dotnet ef migrations add <migration_name> --project .\TrainingPlanner.Infrastructure\TrainingPlanner.Infrastructure.csproj --startup-project .\TrainingPlanner.API\TrainingPlanner.API.csproj

dotnet ef database update `
  --project .\TrainingPlanner.Infrastructure\TrainingPlanner.Infrastructure.csproj `
  --startup-project .\TrainingPlanner.API\TrainingPlanner.API.csproj `
  --connection "<connection_string>"