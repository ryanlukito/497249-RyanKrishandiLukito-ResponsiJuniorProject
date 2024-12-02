create or replace function emp_insert
(
	_nama character varying,
	_id_dept int,
	_id_jabatan int
)
returns int AS
$$
	begin
		insert into karyawan
		(
			nama,
			id_dept,
			id_jab
		)
		values
		(
			_nama,
			_id_dept,
			_id_jabatan
		);
		if found then
			return 1;
		else
			return 0;
		end if;
	end
$$ language plpgsql;
