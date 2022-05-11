SUBDIR	=	Aufgabe2 \
		Aufgabe3 \
		Aufgabe4 \
		Aufgabe4b \
		Aufgabe4c

.PHONY: all clean ${SUBDIR} ${SUBDIR:=-clean}
all: ${SUBDIR}

${SUBDIR}:
	${MAKE} -C ${@} all

clean: ${SUBDIR:=-clean}

${SUBDIR:=-clean}:
	${MAKE} -C ${@:-clean=} clean
