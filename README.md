# EnergyMonitoringAPI

## Descrição do Projeto

`EnergyMonitoringAPI` é uma API desenvolvida com .NET 8.0 para o monitoramento e gerenciamento de produção de energia sustentável. A API oferece operações CRUD (Create, Read, Update, Delete) para registros de produção de energia, com armazenamento e consulta utilizando um banco de dados Oracle.

## Pré-requisitos

- .NET SDK (8.0 ou superior)
- Banco de Dados Oracle ou acesso a uma instância configurada
- Visual Studio, Visual Studio Code ou qualquer outra IDE compatível
- Dependências adicionais, como `Oracle.ManagedDataAccess`, `Dapper`, `xUnit` e `Moq` para testes

## Configuração do Projeto

### 1. Configurando a String de Conexão

A conexão com o banco de dados Oracle deve ser configurada no arquivo `appsettings.json`. Um exemplo de configuração:

```json
{
    "ConnectionStrings": {
        "OracleDb": "User Id=seu_usuario;Password=sua_senha;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=seu_host)(PORT=sua_porta))(CONNECT_DATA=(SID=seu_sid)))"
    },
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    },
    "AllowedHosts": "*"
}
```

> **Importante**: Substitua os valores de `User Id`, `Password`, `Host`, `Port` e `SID` conforme necessário para sua configuração.

### 2. Configuração Inicial

1. Clone o repositório:

   ```bash
   git clone https://github.com/SeuRepositorio/EnergyMonitoringAPI.git
   ```

2. Navegue para o diretório do projeto:

   ```bash
   cd EnergyMonitoringAPI
   ```

3. Restaure as dependências do projeto:

   ```bash
   dotnet restore
   ```

4. Compile o projeto:

   ```bash
   dotnet build
   ```

## Estrutura do Projeto

- **`Controllers/`**: Contém os controladores da API, incluindo `EnergyController`, que gerencia as operações de CRUD.
- **`Models/`**: Contém as classes de modelos de dados, como `EnergyProduction` e `User`.
- **`Repositories/`**: Contém a lógica de interação com o banco de dados.
- **`Services/`**: Contém serviços que encapsulam a lógica de negócios.
- **`Data/`**: Contém a configuração para conexão com o banco de dados (`OracleDbContext`).

## Executando o Projeto

### Execução em HTTP/HTTPS

Para executar o projeto em modo de desenvolvimento, use:

```bash
dotnet run
```

A API estará disponível em `http://localhost:{porta}` ou `https://localhost:{porta}` conforme configurado no `launchSettings.json`.

### Configuração de HTTPS

Para confiar no certificado HTTPS em modo de desenvolvimento:

```bash
dotnet dev-certs https --trust
```

## Documentação da API

A documentação da API está disponível via Swagger. Quando a aplicação estiver em execução, você pode acessar a documentação em:

```
http://localhost:{porta}/swagger
```

## Executando Testes

O projeto inclui testes unitários utilizando `xUnit` e `Moq`. Para executar os testes:

1. Navegue para o diretório de testes (caso tenha):

   ```bash
   cd EnergyMonitoringAPI.Tests
   ```

2. Execute os testes:

   ```bash
   dotnet test
   ```

## Tecnologias Utilizadas

- **.NET 8.0**: Framework para desenvolvimento da API.
- **Oracle Managed Data Access**: Biblioteca para interação com o banco de dados Oracle.
- **Dapper**: Micro ORM para consultas simplificadas ao banco de dados.
- **xUnit**: Framework de testes unitários.
- **Moq**: Biblioteca para criação de mocks em testes.
