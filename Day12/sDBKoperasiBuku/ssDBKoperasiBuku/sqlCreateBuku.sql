USE [DBKoperasiBuku]
GO
CREATE TABLE [mst].[Buku]
(
	[BukuID] [int] IDENTITY (1,1)
	, [Kd_Buku] [varchar](5)
	, [Nm_Buku] [varchar](15)
	, [Jml_Halaman] [int]
	, [Kd_Jenis] [varchar](4)

	
)
GO