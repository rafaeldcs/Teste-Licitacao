/*
 Navicat Premium Data Transfer

 Source Server         : SQL Local
 Source Server Type    : SQL Server
 Source Server Version : 12002269
 Source Host           : LAPTOP-6F9ISQ9R\SQLEXPRESS:1433
 Source Catalog        : Teste
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 12002269
 File Encoding         : 65001

 Date: 21/11/2023 10:21:26
*/


-- ----------------------------
-- Table structure for licitacao
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[licitacao]') AND type IN ('U'))
	DROP TABLE [dbo].[licitacao]
GO

CREATE TABLE [dbo].[licitacao] (
  [id] uniqueidentifier  NOT NULL,
  [numero] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [descricao] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [status] int  NOT NULL,
  [data_abertura] datetime  NOT NULL
)
GO

ALTER TABLE [dbo].[licitacao] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Primary Key structure for table licitacao
-- ----------------------------
ALTER TABLE [dbo].[licitacao] ADD CONSTRAINT [PK__licitaca__3213E83FFFA61A32] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

