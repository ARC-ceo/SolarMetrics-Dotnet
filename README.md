
![Logo](banner.jpg)
# SolarMetrics - API em .NET

**SolarMetrics** é uma API desenvolvida para monitoramento e análise de energia solar, fornecendo dados em tempo real sobre sensores, usuários e ocupação de sistemas. A aplicação permite integrar sensores IoT, gerar relatórios e fornecer dados para aplicativos móveis ou dashboards web. Nosso objetivo é fornecer uma solução confiável para monitoramento inteligente de energia solar, auxiliando residências e empresas a otimizarem o consumo e gerarem insights a partir dos dados coletados.

## Novidades da Aplicação
- Implementação de uma **interface Web** moderna para monitoramento e gestão.  
- Integração da **WebAPI** com a interface web, permitindo interação em tempo real.  
- Visualização de dados de sensores, relatórios e estatísticas diretamente no navegador.  

## Requisitos Funcionais
- Cadastro e gerenciamento de clientes e usuários.  
- Integração com sensores IoT para captura de dados de energia e ocupação.  
- Geração de relatórios detalhados sobre consumo, geração e ocupação.  
- Consulta de dados históricos e em tempo real.  
- Atualização e sincronização de informações entre backend e aplicativos móveis.

## Requisitos Não Funcionais
- **Desempenho:** O sistema deve processar e disponibilizar dados em tempo real com latência mínima.  
- **Segurança:** Proteção de dados sensíveis, autenticação e autorização de usuários.  
- **Disponibilidade:** Sistema deve possuir alta disponibilidade (mínimo 99,5%) para acesso contínuo.  
- **Escalabilidade:** Capacidade de suportar aumento no número de sensores e usuários sem perda de performance.  
- **Manutenibilidade:** Código e arquitetura organizados para facilitar atualizações e correções.  
- **Compatibilidade:** Suporte a múltiplos dispositivos móveis e integração com diferentes sensores IoT.  
- **Confiabilidade:** Garantir integridade dos dados capturados e armazenados, evitando perdas ou inconsistências.  

## Problemas que a aplicação resolve
- Falta de visibilidade sobre a geração e consumo de energia solar.  
- Dificuldade em monitorar ocupação e eficiência de sistemas.  
- Necessidade de relatórios detalhados para tomada de decisão.  
- Integração limitada entre diferentes sistemas de IoT e aplicações móveis.

## Sobre o time

- **Arthur Algate RM:560109**: Responsável pelo banco de dados e Compliance QA.  
- **Carlos Clementino RM:561187**: Responsável pelo desenvolvimento da API em .NET e Java Spring Boot, infraestrutura e práticas de DevOps, e pela integração com dispositivos IoT.  
- **Eder Silva RM:559647**: Responsável pela criação do APP mobile.

## Como rodar a aplicação

### Pré-requisitos
- .NET 9 SDK ou superior  
- IDE recomendada: **Rider**  
- Oracle Database

### Passos para executar

1. Clone o repositório:  
```bash
git clone https://github.com/ARC-ceo/SolarMetrics-Dotnet.git
```

2. Abra o projeto no **Rider**.  


3. Execute a aplicação:  
```bash
dotnet run
```

4. A API estará disponível em: `http://localhost:5090`.

### Testando a API
A documentação dos endpoints está disponível via **Swagger UI**:  
`http://localhost:5090/index.html`

## Diagramas


### Modelo Físico
![Arquitetura](MER.png)

## Apresentação
Assista ao vídeo explicando a proposta tecnológica, o público-alvo e os problemas que a aplicação resolve:  
[Apresentação SolarMetrics](https://youtu.be/Fcza8JBvsyw)

## Endpoints da API

A API foi documentada com **Swagger / OpenAPI**, oferecendo exemplos completos de requisição e resposta.

### Endpoints principais

| Método | Endpoint       | Descrição                                    |
|--------|----------------|---------------------------------------------|
| GET    | /cliente       | Listar todos clientes cadastrados           |
| PUT    | /cliente       | Atualizar cadastro do cliente               |
| POST   | /cliente       | Criar cadastro do cliente                   |
| GET    | /cliente/{id}  | Buscar cadastro do cliente                  |
| DELETE | /cliente/{id}  | Deletar cadastro do cliente                 |

> Para todos os endpoints, exemplos detalhados de request e response estão disponíveis no **Swagger UI**.

## Tecnologias utilizadas
- .NET 9 / C#  
- ASP.NET Core Web API  
- Entity Framework Core  
- Oracle Database  
- Swagger / OpenAPI  

---

**SolarMetrics** — Sua energia. Seu controle ☀️
