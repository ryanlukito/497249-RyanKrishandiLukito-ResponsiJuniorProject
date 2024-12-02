create or replace function emp_select()
returns table
(
	_id_karyawan character varying,
	_nama character varying,
	_id_dept int,
	_nama_dept character varying
)
language plpgsql
AS
$$
	begin
		return query
		select k.id_karyawan, k.nama, k.id_dept, d.nama_dept from karyawan k inner join departemen d on k.id_dept = d.id_departemen;
	end
$$
