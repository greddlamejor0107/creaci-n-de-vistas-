-- 12. Total de Ventas por Cliente
CREATE VIEW vw_total_ventas_por_cliente AS
SELECT 
    c.nombre_cliente,
    SUM(v.monto_venta) AS total_ventas
FROM ventas v
JOIN clientes c ON v.id_cliente = c.id_cliente
GROUP BY c.nombre_cliente;

-- SELECT para visualizar la vista
SELECT * FROM vw_total_ventas_por_cliente;