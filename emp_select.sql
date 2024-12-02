create or replace function emp_select()
returns table
(
	_id_karyawan character varying,
	_nama character varying,
	_id_dept int,
	_nama_dept character varying,
	_id_jabatan int
)
language plpgsql
AS
$$
	begin
		return query
		select k.id_karyawan, k.nama, k.id_dept, d.nama_dept, j.id_jabatan from karyawan k 
		inner join departemen d on k.id_dept = d.id_departemen
		inner join jabatan j on k.id_jab = j.id_jabatan;
	end
$$
