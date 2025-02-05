using CsvHelper.Configuration;
using CsvHelper;
using SportsScheduleProLibrary.Data;
using SportsScheduleProLibrary.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportsSchedulePro.Services
{
    public class ExportService
    {

        public static string ExportSchedule()
        {

            //Figure this out

            using (var writer = new StringWriter())
            {
                using (CsvWriter excelWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    SportsScheduleProDataContext dbc = new SportsScheduleProDataContext();

                    excelWriter.Context.RegisterClassMap<SportsScheduleProDataMap>();
                    excelWriter.WriteHeader<Game>();
                    excelWriter.NextRecord();
                    excelWriter.WriteRecords(dbc.Games.Include(s => s.Field).Include(s => s.League).OrderBy(s => s.League).OrderBy(s => s.ChosenScheduleTime).ToList());
                    writer.Flush();
                }

                return writer.ToString();
            }
        }
    }

    class SportsScheduleProDataMap : ClassMap<Game>
    {
        public SportsScheduleProDataMap()
        {
            Map(s => s.ChosenScheduleTime.DayOfWeek).Name("Day");
            Map(s => s.ChosenScheduleTime.Date).Name("Date");
            Map(s => s.ChosenScheduleTime.TimeOfDay).Name("Time");
            Map(s => s.AwayTeam).Name("Team1");
            Map(s => s.HomeTeam).Name("Team2");
            Map(s => s.Description).Name("Match");
            Map(s => s.Field).Name("Field");
            Map(s => s.League).Name("League");
        }
    }
}
