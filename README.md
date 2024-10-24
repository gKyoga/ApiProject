

# 🚀 API de Cadastro de Usuário - ASP.NET & C# 

Bem-vindo ao repositório da **API de Cadastro de Usuário**! 🎉 Aqui você encontrará uma API RESTful desenvolvida com **ASP.NET Core** e **C#** para realizar o cadastro de usuários.

## 🔧 Tecnologias Utilizadas

- ASP.NET Core 🖥️
- C# 💻
- Entity Framework Core 🗄️
- SQL Server 🛢️
- Swagger 📝

## 📦 Funcionalidades

- Cadastro de novos usuários 👤
- Consulta de usuários 🔍
- Atualização de informações de usuários ✏️
- Exclusão de usuários ❌

## 🚀 Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git
   ```

2. Navegue até o diretório do projeto:
   ```bash
   cd nome-do-repositorio
   ```

3. Configure a string de conexão no arquivo `appsettings.json` com seu banco de dados SQL Server.

4. Execute as migrações para criar o banco de dados:
   ```bash
   dotnet ef database update
   ```

5. Execute o projeto:
   ```bash
   dotnet run
   ```

## 🛠️ Endpoints

- **Adicionar** `/api/usuarios` - Cadastra um novo usuário.
- **BuscarTodos** `/api/usuarios` - Lista todos os usuários.
- **BuscarId** `/api/usuarios/{id}` - Retorna um usuário pelo ID.
- **Update** `/api/usuarios/{id}` - Atualiza um usuário.
- **Remover** `/api/usuarios/{id}` - Exclui um usuário.

## 📜 Licença

Este projeto está sob a licença MIT. Sinta-se à vontade para usá-lo e modificá-lo! 😊
