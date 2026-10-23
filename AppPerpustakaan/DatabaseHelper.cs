using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

namespace AppPerpustakaan
{
    public class DatabaseHelper
    {
        private static string connectionString = "Data Source=perpustakaan.db";

        public static void InitializeDatabase()
        {
            using (IDbConnection db = new SqliteConnection(connectionString))
            {
                // 1. Tabel Ebooks (Judul, Kategori, Path PDF)
                string createEbooks = @"
                    CREATE TABLE IF NOT EXISTS Ebooks (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Judul TEXT NOT NULL,
                        Kategori TEXT,
                        FilePath TEXT NOT NULL
                    );";

                // 2. Tabel Notes (Catatan terikat ke ID buku)
                string createNotes = @"
                    CREATE TABLE IF NOT EXISTS Notes (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        EbookId INTEGER NOT NULL,
                        IsiCatatan TEXT,
                        FOREIGN KEY (EbookId) REFERENCES Ebooks(Id) ON DELETE CASCADE
                    );";

                // 4. Tabel Nodes (Titik Visual Grafik)
                string createNodes = @"
                    CREATE TABLE IF NOT EXISTS Nodes (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Label TEXT NOT NULL
                    );";

                // 5. Tabel Edges (Garis Relasi Grafik)
                string createEdges = @"
                    CREATE TABLE IF NOT EXISTS Edges (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        SourceNodeId INTEGER NOT NULL,
                        TargetNodeId INTEGER NOT NULL,
                        FOREIGN KEY (SourceNodeId) REFERENCES Nodes(Id),
                        FOREIGN KEY (TargetNodeId) REFERENCES Nodes(Id)
                    );";

                // Eksekusi pembuatan tabel
                db.Execute(createEbooks);
                db.Execute(createNotes);
                db.Execute(createNodes);
                db.Execute(createEdges);
            }
        }
    }
}