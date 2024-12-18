create or replace function emp_update
(
	_id character varying,
	_nama character varying,
	_id_dept int,
	_id_jabatan int
)
returns int AS
$$
	begin
		update karyawan SET
			nama = _nama,
			id_dept = _id_dept,
			id_jab = _id_jabatan
		WHERE id_karyawan = _id;
		if found then
			return 1;
		else
			return 0;
		end if;
	end
$$ language plpgsql
