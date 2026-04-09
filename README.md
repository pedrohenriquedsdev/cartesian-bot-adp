# 🤖 CartesianBot

> Projeto de navegação de robô em grade cartesiana, desenvolvido em C#.

---

## 📋 Sobre o Projeto

O **CartesianBot** é um projeto de aplicação console em C# que simula a navegação de um robô em uma grade cartesiana (plano 2D). O foco está na lógica de movimentação, controle de direção e execução de comandos sequenciais — explorando conceitos de orientação a objetos e raciocínio algorítmico.

---

## ✨ Funcionalidades

- Movimentação do robô em grade cartesiana (eixos X e Y)
- Controle de direção: Norte, Sul, Leste e Oeste
- Rotação do robô para esquerda e direita
- Execução de sequências de comandos
- Registro do histórico de posições percorridas

---

## 🗂️ Estrutura do Projeto

```
cartesian-bot-adp/
├── CartesianBot.ConsoleApp/   # Projeto principal (console)
├── docs/                      # Documentação adicional
├── .vscode/                   # Configurações do VS Code
├── CartesianBot.slnx          # Arquivo de solução .NET
└── .gitignore
```

---

## 🚀 Como Executar

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) 8.0 ou superior

### Passos

1. Clone o repositório:
   ```bash
   git clone https://github.com/pedrohenriquedsdev/cartesian-bot-adp.git
   cd cartesian-bot-adp
   ```

2. Restaure as dependências:
   ```bash
   dotnet restore
   ```

3. Execute o projeto:
   ```bash
   dotnet run --project CartesianBot.ConsoleApp
   ```

---

## 🧠 Lógica de Navegação

O robô parte de uma posição inicial na grade e aceita os seguintes comandos:

| Comando | Ação                          |
|---------|-------------------------------|
| `M`     | Mover um passo à frente       |
| `L`     | Girar 90° para a esquerda     |
| `R`     | Girar 90° para a direita      |

A direção atual determina para onde o robô avança ao receber o comando `M`:

| Direção | Movimento       |
|---------|-----------------|
| Norte   | Y + 1           |
| Sul     | Y - 1           |
| Leste   | X + 1           |
| Oeste   | X - 1           |

**Exemplo:**
```
Posição inicial: (0, 0) — Norte
Comandos: M M R M
Resultado: (1, 2) — Leste
```

---

## 🛠️ Tecnologias Utilizadas

- **C#** — linguagem principal
- **.NET** — plataforma de execução
- **Console App** — interface de entrada e saída

---

## 👤 Autor

**Pedro Henrique**

[![GitHub](https://img.shields.io/badge/GitHub-pedrohenriquedsdev-181717?style=flat&logo=github)](https://github.com/pedrohenriquedsdev)

---

## 📄 Licença

Este projeto está sob a licença MIT. Consulte o arquivo [LICENSE](LICENSE) para mais detalhes.
