# EmployeeAPI - Enterprise .NET CI/CD & Kubernetes Project

## Overview

This project demonstrates a complete enterprise-grade software delivery pipeline using ASP.NET Core, Docker, GitHub Actions, Kubernetes, and Helm.

The goal of this project was not only to build a REST API, but also to implement the complete DevOps lifecycle used in modern software development.

---

## Tech Stack

### Backend

- ASP.NET Core (.NET 10)
- Entity Framework Core
- SQL Server

### Testing

- xUnit
- Integration Testing

### Version Control

- Git
- GitHub

### CI/CD

- GitHub Actions
- Build Automation
- Unit Testing
- Artifact Publishing

### Containers

- Docker
- Docker Compose
- Docker Hub

### Kubernetes

- Minikube
- Pods
- Deployments
- Services
- ConfigMaps
- Secrets
- Persistent Volumes
- Ingress
- Helm

### Cloud

- Render Deployment

---

# Project Architecture

```
Developer
     │
     ▼
Git
     │
     ▼
GitHub
     │
     ▼
GitHub Actions
     │
     ▼
Restore
     │
     ▼
Build
     │
     ▼
Unit Tests
     │
     ▼
Publish
     │
     ▼
Docker Build
     │
     ▼
Docker Hub
     │
     ▼
Kubernetes
     │
     ▼
Ingress
     │
     ▼
EmployeeAPI
     │
     ▼
SQL Server
```

---

# CI/CD Pipeline

Implemented a complete GitHub Actions pipeline.

Pipeline includes

- Restore NuGet Packages
- Build Solution
- Run Unit Tests
- Publish Application
- Upload Build Artifacts
- Build Docker Image
- Push Docker Image to Docker Hub

---

# Docker

Implemented

- Dockerfile
- Multi-stage Build
- Docker Compose
- Docker Hub Integration

---

# Kubernetes

Implemented

- Deployment
- Service
- ConfigMap
- Secret
- Persistent Volume
- Persistent Volume Claim
- SQL Server Deployment
- Ingress
- Helm Chart

---

# Helm

Created a reusable Helm Chart for application deployment.

Supports

- Deployment
- Service
- ConfigMap
- Secret
- Ingress
- PVC

---

# Features

- REST API
- SQL Server Integration
- Entity Framework Core
- Swagger
- Automated Testing
- Enterprise CI/CD
- Containerized Deployment
- Kubernetes Orchestration
- Helm Packaging

---

# GitHub Actions

Every push automatically

- Builds the application
- Executes Unit Tests
- Publishes the project
- Builds Docker Image
- Pushes Docker Image

---

# Docker Hub

Docker Image

```
sdhar2/employeeapi:latest
```

---

# Project Highlights

✔ Enterprise CI/CD Pipeline

✔ Automated Testing

✔ Dockerized Application

✔ Kubernetes Deployment

✔ Helm Chart

✔ Persistent Storage

✔ ConfigMaps & Secrets

✔ Ingress Configuration

✔ SQL Server Integration

✔ Production-ready Architecture

---

# Learning Outcomes

This project demonstrates understanding of

- Enterprise Software Development
- DevOps
- CI/CD
- Containerization
- Kubernetes
- Cloud Deployment
- Infrastructure as Code
- Production Deployment Strategies

---

# Author

Supriyo Dhar

.NET Full Stack Developer

GitHub

https://github.com/supriyo34

LinkedIn
https://www.linkedin.com/in/supriyo-dhar-031a6920a/
