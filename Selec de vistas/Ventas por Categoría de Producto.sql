-- 2. Ventas por Categoría de Producto
CREATE VIEW vw_ventas_por_categoria AS
SELECT 
    c.id_categoria,
    c.nombre_categoria,
    YEAR(v.fecha_venta) AS año,
    MONTH(v.fecha_venta) AS mes,
    SUM(v.monto_venta) AS total_ventas
FROM ventas v
JOIN productos p ON v.id_producto = p.id_producto
JOIN categorias c ON p.id_categoria = c.id_categoria
GROUP BY c.id_categoria, c.nombre_categoria, YEAR(v.fecha_venta), MONTH(v.fecha_venta);

-- Consulta para mostrar los datos de la vista
SELECT * FROM vw_ventas_por_categoria;