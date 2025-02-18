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
                                    1
                               FROM DateSeries
                              WHERE strftime('%w', ExcludedDate) IN ('3');-- Excluding Wednesdays (3)
