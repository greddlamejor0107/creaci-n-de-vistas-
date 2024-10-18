-- 3. Total de Ventas por Categoría
CREATE VIEW vw_total_ventas_por_categoria AS
SELECT 
    c.id_categoria,
    c.nombre_categoria,
    SUM(v.monto_venta) AS total_ventas
FROM ventas v
JOIN productos p ON v.id_producto = p.id_producto
JOIN categorias c ON p.id_categoria = c.id_categoria
GROUP BY c.id_categoria, c.nombre_categoria;

-- Consulta para mostrar los datos de la vista
SELECT * FROM vw_total_ventas_por_categoria;