# ControlePagamentoAPI

O ControlePagamentoAPI é uma aplicação para gerenciar pagamentos e clientes. A API permite criar e listar pagamentos e clientes, além de atualizar o status dos pagamentos.

## Pré-requisitos
- .NET 8 SDK
- Banco de dados PostgreSQL

## Clonando o Repositório
Clone o repositório para sua máquina local usando o comando:

```
git clone https://github.com/seu_usuario/ControlePagamentoAPI.git
```

## Configuração do Banco de Dados
1. Configure a string de conexão do banco de dados no arquivo `appsettings.json` localizado na raiz do projeto `ControlePagamentosAPI`:
```
"ConnectionStrings": { "SqlConnection": "Host=localhost;Database=postgres;Username=postgres;Password=sua_senha" } }
```

## Instalando Dependências
Navegue até a pasta do projeto e restaure as dependências do .NET:
```
cd ControlePagamentoAPI
dotnet restore
```

## Executando Migrações
Aplique as migrações para criar o banco de dados e as tabelas necessárias:
```
cd Infrasctructure 
dotnet ef database update
```

## Iniciando a Aplicação
Navegue até a pasta do projeto principal e inicie a aplicação:
```
cd ControlePagamentosAPI 
dotnet run
```

A aplicação estará disponível em `https://localhost:7101` (https) ou `http://localhost:5058` (http).

## Endpoints Disponíveis
### Clientes
- `GET /api/clientes/todos`: Lista todos os clientes.
- `POST /api/clientes`: Cria um novo cliente.
- `GET /api/clientes/{id}`: Obtém um cliente pelo ID.

### Pagamentos
- `POST /api/pagamentos`: Cria um novo pagamento.
- `GET /api/pagamentos?clienteId={clienteId}`: Obtém pagamentos por ID do cliente.
- `PUT /api/pagamentos/{id}/status`: Atualiza o status de um pagamento.

## Configuração de CORS
Para permitir requisições de diferentes origens, o CORS foi configurado no projeto. Você pode ajustar as configurações de CORS no arquivo `Startup.cs` conforme necessário.
