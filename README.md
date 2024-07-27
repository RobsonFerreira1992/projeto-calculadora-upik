# Calculadora API

Um exemplo simples de uma API de calculadora construída com ASP.NET Core e um frontend em JavaScript.

## Tabela de Conteúdos

- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Uso](#uso)
- [Endpoints da API](#endpoints-da-api)
- [Contribuição](#contribuição)
- [Licença](#licença)
- [Autores](#autores)

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (para rodar o frontend)
- [Visual Studio Code](https://code.visualstudio.com/) ou outra IDE de sua preferência

## Instalação

### Backend

1. Clone o repositório:
    ```bash
    git clone https://github.com/seu-usuario/calculadora-api.git
    cd calculadora-api
    ```

2. Navegue até o diretório do projeto e instale as dependências:
    ```bash
    cd CalculadoraApi
    dotnet restore
    ```

3. Compile e rode a aplicação:
    ```bash
    dotnet build
    dotnet run
    ```

### Frontend

1. Navegue até o diretório do frontend:
    ```bash
    cd frontend
    ```

2. Instale as dependências:
    ```bash
    npm install
    ```

3. Rode a aplicação:
    ```bash
    npm start
    ```

## Uso

### Backend

A API estará rodando em `https://localhost:7144`. Você pode testar os endpoints usando o Postman ou qualquer outro cliente HTTP.

### Frontend

A aplicação frontend estará rodando em `http://localhost:5500`. Abra essa URL no seu navegador.

## Endpoints da API

### Soma

- **URL:** `/Calculadora/soma`
- **Método:** `POST`
- **Corpo da Requisição:**
    ```json
    {
      "number1": 10,
      "number2": 5
    }
    ```
- **Resposta de Sucesso:**
    ```json
    {
      "result": 15
    }
    ```

### Subtração

- **URL:** `/Calculadora/subtracao`
- **Método:** `POST`
- **Corpo da Requisição:**
    ```json
    {
      "number1": 10,
      "number2": 5
    }
    ```
- **Resposta de Sucesso:**
    ```json
    {
      "result": 5
    }
    ```

### Multiplicação

- **URL:** `/Calculadora/multiplicacao`
- **Método:** `POST`
- **Corpo da Requisição:**
    ```json
    {
      "number1": 10,
      "number2": 5
    }
    ```
- **Resposta de Sucesso:**
    ```json
    {
      "result": 50
    }
    ```

### Divisão

- **URL:** `/Calculadora/divisao`
- **Método:** `POST`
- **Corpo da Requisição:**
    ```json
    {
      "number1": 10,
      "number2": 5
    }
    ```
- **Resposta de Sucesso:**
    ```json
    {
      "result": 2
    }
    ```

## Contribuição

1. Fork o repositório
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova feature'`)
4. Push para a branch (`git push origin feature/nova-feature`)
5. Abra um Pull Request

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Autores

- **Seu Nome** - [Seu GitHub](https://github.com/seu-usuario)

---

### Imagens e Demonstrações

#### Arquitetura da Aplicação

![Arquitetura da Aplicação](path/to/your/image.png)

#### Demonstração da API

![Demonstração da API](path/to/your/image.png)