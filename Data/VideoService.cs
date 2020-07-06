using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BlazorDapperCrud.Data
{
    public class VideoService : IVideoService
    {
        private readonly SqlConnectionConfig _config;

        public VideoService(SqlConnectionConfig config)
        {
            _config = config;
        }

        //Add (create) a Video Table Row (SQL Insert)
        public async Task<bool> VideoInsert(Video video)
        {
            await using var conn = new SqlConnection(_config.Value);
            var parameters = new DynamicParameters();
            parameters.Add("Title", video.Title, DbType.String);
            parameters.Add("DatePublished", video.DatePublished, DbType.Date);
            parameters.Add("IsActive", video.IsActive, DbType.Boolean);

            //RAW Sql method
            const string query = @"INSERT INTO Video(Title, IsActive, DatePublished) VALUES(@Title, @IsActive, @DatePublished)";
            await conn.ExecuteAsync(query, new { video.DatePublished, video.Title, video.IsActive },
                commandType: CommandType.Text);

            return true;
        }
    }
}
