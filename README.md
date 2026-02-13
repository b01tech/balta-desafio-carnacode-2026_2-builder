![CR-2](https://github.com/user-attachments/assets/77a4d99a-9524-4322-9482-3f6833d9b2a0)

## 🥁 CarnaCode 2026 - Desafio 02 - Builder

Oi, eu sou o Bruno e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio

No desafio **Builder** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:

- ✅ Boas Práticas de Software
- ✅ Código Limpo
- ✅ SOLID
- ✅ Design Patterns (Padrões de Projeto)

## Problema

Sistema precisa gerar diferentes tipos de relatórios (PDF, Excel, HTML) com múltiplas configurações opcionais (cabeçalho, rodapé, gráficos, tabelas, filtros).
O código atual usa construtores enormes ou muitos setters, tornando difícil criar relatórios

# Solução

implementado o padrão **Builder** para evitar o construtor gigante e garantir a criação de objetos consistentes e flexíveis.

### Destaques da Implementação:

- **Encapsulamento**: A classe `SalesReport` agora possui construtor interno e setters internos, impedindo a criação direta de objetos inválidos.
- **Fluent Interface**: O `SalesReportBuilder` permite encadear chamadas de métodos de forma legível (ex: `.WithTitle(...).WithFormat(...)`).
- **Separação de Responsabilidades**: A lógica de construção foi separada da lógica de negócio do relatório.

### Exemplo de Uso

```csharp
var builder = new SalesReportBuilder();

var report = builder
    .WithTitle("Vendas Q1")
    .WithFormat("PDF")
    .WithStartDate(new DateTime(2025, 1, 1))
    .WithHeader("Relatório Trimestral")
    .WithCharts("Barras")
    .Build();

report.Generate();
```

## Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns

Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio

[Repositório Central do Desafio](https://github.com/b01tech/desafio-carnacode-2026-design-patterns.git)
