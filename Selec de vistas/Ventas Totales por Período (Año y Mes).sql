CREATE VIEW vw_ventas_totales_periodo AS
SELECT 
    YEAR(fecha_venta) AS año,
    MONTH(fecha_venta) AS mes,
    SUM(monto_venta) AS total_ventas
FROM ventas
GROUP BY YEAR(fecha_venta), MONTH(fecha_venta);

SELECT * FROM vw_ventas_totales_periodo;