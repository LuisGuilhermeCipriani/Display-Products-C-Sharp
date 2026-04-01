# 🛍️ Display Products - C#

Projeto em C# desenvolvido para demonstrar conceitos fundamentais de **Programação Orientada a Objetos (POO)**, como:

* Herança
* Polimorfismo
* Sobrescrita de métodos (`override`)
* Uso de listas genéricas (`List<T>`)

---

## 📌 Descrição

O sistema permite cadastrar diferentes tipos de produtos:

* Produto comum
* Produto usado
* Produto importado

Cada tipo de produto possui um comportamento específico na exibição da sua **etiqueta de preço (PriceTag)**.

---

## 🚀 Funcionalidades

* Cadastro de múltiplos produtos
* Diferenciação de tipos via entrada do usuário (`c`, `u`, `i`)
* Cálculo automático de preço total para produtos importados
* Exibição personalizada das informações de cada produto

---

## 🧠 Conceitos Aplicados

### 🔹 Herança

A classe `Product` é a base para:

* `UsedProduct`
* `ImportedProduct`

### 🔹 Polimorfismo

Uso de sobrescrita do método:

```csharp
public virtual string PriceTag()
```

Com implementações específicas nas classes filhas.

---

## 🏗️ Estrutura do Projeto

```
DisplayProducts
│
├── Program.cs
└── Entities
    ├── Product.cs
    ├── UsedProduct.cs
    └── ImportedProduct.cs
```

---

## 📥 Entrada de Dados

O programa solicita:

1. Quantidade de produtos
2. Para cada produto:

   * Tipo (`c`, `u`, `i`)
   * Nome
   * Preço
   * (Se usado) Data de fabricação
   * (Se importado) Taxa de importação

---

## 📤 Saída

Exibe a lista de produtos com suas respectivas etiquetas:

### Exemplo:

```
PRICE TAGS:
Notebook $ 1100.00
Tablet (used) $ 400.00 (Manufacture date: 15/03/2018)
iPhone $ 1200.00 (Customs fee: $ 200.00)
```

---

## 💻 Tecnologias Utilizadas

* C#
* .NET
* Console Application

---

## ▶️ Como Executar

1. Clone o repositório:

```
git clone https://github.com/LuisGuilhermeCipriani/Display-Products-C-Sharp.git
```

2. Acesse a pasta do projeto:

```
cd Display-Products-C-Sharp
```

3. Compile e execute:

```
dotnet run
```

---

## 📚 Aprendizados

Este projeto reforça:

* Modelagem orientada a objetos
* Reutilização de código com herança
* Extensibilidade com polimorfismo
* Organização de código em camadas

---

## 👨‍💻 Autor

Desenvolvido por **Luís Guilherme Cipriani**
