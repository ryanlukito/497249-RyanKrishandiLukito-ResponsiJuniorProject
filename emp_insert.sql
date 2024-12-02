create or replace function emp_insert
(
	_nama character varying,
	_id_dept int
)
returns int AS
$$
	begin
		insert into karyawan
		(
			nama,
			id_dept
		)
		values
		(
			_nama,
			_id_dept
		);
		if found then
			return 1;
		else
			return 0;
		end if;
	end
$$ language plpgsql;
