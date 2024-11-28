# EnergyMonitoringAPI

## Descrição do Projeto

`EnergyMonitoringAPI` é uma API desenvolvida com .NET 8.0 para o monitoramento e gerenciamento de produção de energia sustentável. A API oferece operações CRUD (Create, Read, Update, Delete) para registros de produção de energia, com armazenamento e consulta utilizando um banco de dados Oracle.

---

## Integrantes

- **Bruno Ramos da Costa** (RM551942)  
- **Guilherme Faria de Aguiar** (RM551374)  
- **Henrique Roncon Pereira** (RM99161)  
- **Lucas Carabolad Bob** (RM550519)  
- **Thiago Ulrych** (RM97951)  

---

## Pré-requisitos

- **.NET SDK (8.0 ou superior)**  
- **Banco de Dados Oracle** ou acesso a uma instância configurada  
- IDE compatível, como **Visual Studio** ou **Visual Studio Code**  
- Dependências adicionais:
  - `Oracle.ManagedDataAccess`
  - `Dapper`
  - `xUnit`
  - `Moq` (para testes)

---

## Configuração do Projeto

### 1. Configurando a String de Conexão

Configure a conexão com o banco de dados Oracle no arquivo `appsettings.json`. Exemplo:

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

> **Nota**: Substitua os valores de `User Id`, `Password`, `Host`, `Port` e `SID` conforme a sua configuração.

---

### 2. Configuração Inicial

1. Clone o repositório:

   ```bash
   git clone https://github.com/SeuRepositorio/EnergyMonitoringAPI.git
   ```

2. Acesse o diretório do projeto:

   ```bash
   cd EnergyMonitoringAPI
   ```

3. Restaure as dependências:

   ```bash
   dotnet restore
   ```

4. Compile o projeto:

   ```bash
   dotnet build
   ```

---

## Estrutura do Projeto

- **`Controllers/`**: Contém os controladores da API (ex.: `EnergyController` para operações CRUD).
- **`Models/`**: Contém os modelos de dados, como `EnergyProduction` e `User`.
- **`Repositories/`**: Lógica de interação com o banco de dados.
- **`Services/`**: Serviços encapsulando a lógica de negócios.
- **`Data/`**: Configuração para conexão com o banco (`OracleDbContext`).

---

## Executando o Projeto

### Modo Desenvolvimento

Execute o comando:

```bash
dotnet run
```

A API estará disponível em:

- **HTTP**: `http://localhost:{porta}`
- **HTTPS**: `https://localhost:{porta}`

> **Porta** configurada em `launchSettings.json`.

### Certificado HTTPS

Para confiar no certificado em ambiente de desenvolvimento:

```bash
dotnet dev-certs https --trust
```

---

## Documentação da API

A documentação da API é gerada pelo Swagger. Com a aplicação em execução, acesse:

```
http://localhost:{porta}/swagger
```

---

## Executando Testes

Os testes unitários são implementados com `xUnit` e `Moq`. Para executá-los:

1. Navegue até o diretório de testes:

   ```bash
   cd EnergyMonitoringAPI.Tests
   ```

2. Execute os testes:

   ```bash
   dotnet test
   ```

---

## Tecnologias Utilizadas

- **.NET 8.0**: Framework para desenvolvimento da API.
- **Oracle Managed Data Access**: Biblioteca de conexão com Oracle.
- **Dapper**: Micro ORM para consultas simplificadas.
- **xUnit**: Framework para testes unitários.
- **Moq**: Biblioteca para mocks em testes.

