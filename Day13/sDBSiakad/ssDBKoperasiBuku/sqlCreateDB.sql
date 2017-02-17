USE [master]
GO
CREATE DATABASE [DBKoperasiBuku]
ON PRIMARY
(NAME = N'DBKoperasiBuku_Data', FILENAME = N'C:\Batch102\Database\DATA\DBKoperasiBuku_Data.mdf')
LOG ON
(NAME = N'DBKoperasiBuku_Log', FILENAME = N'C:\Batch102\Database\LOG\DBKoperasiBuku_Log.ldf')
