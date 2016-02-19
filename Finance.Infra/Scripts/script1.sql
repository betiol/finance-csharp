CREATE TABLE [dbo].[CategoriaDespesas] (
    [CategoriaDespesaId] [int] NOT NULL IDENTITY,
    [DescricaoCategoriaDespesa] [varchar](150) NOT NULL,
    CONSTRAINT [PK_dbo.CategoriaDespesas] PRIMARY KEY ([CategoriaDespesaId])
)
CREATE TABLE [dbo].[CategoriaReceitas] (
    [CategoriaReceitasId] [int] NOT NULL IDENTITY,
    [DescricaoCategoriaReceitas] [varchar](150) NOT NULL,
    CONSTRAINT [PK_dbo.CategoriaReceitas] PRIMARY KEY ([CategoriaReceitasId])
)
CREATE TABLE [dbo].[Despesas] (
    [DespesaId] [int] NOT NULL IDENTITY,
    [Descricao] [varchar](150) NOT NULL,
    [Valor] [decimal](18, 2) NOT NULL,
    [DataVencimento] [datetime] NOT NULL,
    [Pago] [bit] NOT NULL,
    [DataPagamento] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Despesas] PRIMARY KEY ([DespesaId])
)
CREATE TABLE [dbo].[Receitas] (
    [ReceitaId] [int] NOT NULL IDENTITY,
    [Descricao] [varchar](150) NOT NULL,
    [Valor] [decimal](18, 2) NOT NULL,
    [DataDoRecebimento] [datetime] NOT NULL,
    [Recebido] [bit] NOT NULL,
    [CategoriaReceitasId] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Receitas] PRIMARY KEY ([ReceitaId])
)
CREATE INDEX [IX_CategoriaReceitasId] ON [dbo].[Receitas]([CategoriaReceitasId])
ALTER TABLE [dbo].[Receitas] ADD CONSTRAINT [FK_dbo.Receitas_dbo.CategoriaReceitas_CategoriaReceitasId] FOREIGN KEY ([CategoriaReceitasId]) REFERENCES [dbo].[CategoriaReceitas] ([CategoriaReceitasId])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)