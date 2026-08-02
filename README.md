                                                                           Developer
                                                                               │
                                                                               │
                                                                     Write ASP.NET Core Code
                                                                               │
                                                                               ▼
                                                                    Commit Changes (Git)
                                                                               │
                                                                               ▼
                                                                  Push to GitHub Repository
                                                                               │
                                                                               ▼
                                                                  GitHub Actions Workflow Starts
                                                                               │
                                                        ┌──────────────────────┴──────────────────────┐
                                                        │                                             │
                                                        ▼                                             ▼
                                                ========================= CI PIPELINE =========================
                                                
                                                        Job 1 : Build Solution
                                                        ----------------------
                                                        Checkout Repository
                                                                │
                                                                ▼
                                                        Setup .NET SDK
                                                                │
                                                                ▼
                                                        dotnet restore
                                                                │
                                                                ▼
                                                        dotnet build
                                                                │
                                                                ▼
                                                        Upload Source Artifact
                                                                │
                                                                ▼
                                                
                                                        Job 2 : Run Unit Tests
                                                        ----------------------
                                                        Download Source Artifact
                                                                │
                                                                ▼
                                                        Setup .NET SDK
                                                                │
                                                                ▼
                                                        dotnet test
                                                                │
                                                                ▼
                                                        All Tests Passed?
                                                          │
                                                      ┌───┴────┐
                                                      │        │
                                                     YES      NO
                                                      │        │
                                                      ▼        ▼
                                                 Continue   Pipeline Stops ❌
                                                
                                                                │
                                                                ▼
                                                
                                                        Job 3 : Publish
                                                        ----------------
                                                        Download Source Artifact
                                                                │
                                                                ▼
                                                        dotnet publish
                                                                │
                                                                ▼
                                                        Publish Folder
                                                                │
                                                                ▼
                                                        Upload Publish Artifact
                                                
                                                                │
                                                                ▼
                                                
                                                        Job 4 : Docker
                                                        ----------------
                                                        Checkout Repository
                                                                │
                                                                ▼
                                                        Login Docker Hub
                                                                │
                                                                ▼
                                                        docker build
                                                                │
                                                                ▼
                                                        Docker Image Created
                                                                │
                                                                ▼
                                                        docker push
                                                                │
                                                                ▼
                                                ======================== END OF CI ============================
                                                
                                                                    Docker Hub
                                                                         │
                                                                         ▼
                                                          sdhar2/employeeapi:latest
                                                                         │
                                                                         ▼
                                                
                                                ========================= DEPLOYMENT ==========================
                                                
                                                Option 1 (Local Docker Desktop)
                                                
                                                docker compose up -d
                                                
                                                        │
                                                        ├───────────────┐
                                                        ▼               ▼
                                                
                                                 Employee API      SQL Server
                                                    Container        Container
                                                
                                                        │               │
                                                        └──────┬────────┘
                                                               ▼
                                                
                                                     http://localhost:5001
                                                
                                                ===============================================================
                                                
                                                Option 2 (Cloud)
                                                
                                                Docker Hub
                                                      │
                                                      ▼
                                                Render
                                                      │
                                                      ▼
                                                Pull Docker Image
                                                      │
                                                      ▼
                                                Start Container
                                                      │
                                                      ▼
                                                Public URL
                                                
                                                https://employeeapi-90ac.onrender.com
                                                
                                                ===============================================================
                                                
                                                Future (Production)
                                                
                                                GitHub
                                                   │
                                                   ▼
                                                GitHub Actions
                                                   │
                                                   ▼
                                                Docker Hub
                                                   │
                                                   ▼
                                                Linux Server
                                                   │
                                                   ▼
                                                docker pull
                                                   │
                                                   ▼
                                                docker compose up -d
                                                   │
                                                   ▼
                                                Production API
