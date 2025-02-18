WITH RECURSIVE DateSeries AS (
    SELECT date('2025-03-01') AS ExcludedDate
    UNION ALL
    SELECT date(ExcludedDate, '+1 day') 
      FROM DateSeries
     WHERE ExcludedDate < date('2025-04-19') 
)
INSERT INTO ExcludedGameDate (
                                 IsDeleted,
                                 ExcludedDate,
                                 TeamId
                             )
                             SELECT 0,
                                    ExcludedDate,
                                    38
                               FROM DateSeries
                              WHERE strftime('%w', ExcludedDate) NOT IN ('6');-- Excluding Everything but Saturday (6)
