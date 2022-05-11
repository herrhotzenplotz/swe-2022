SUBDIR	=	aufgabe1 \
		aufgabe2

.PHONY: all clean ${SUBDIR} ${SUBDIR:=-clean}
all: ${SUBDIR}

${SUBDIR}:
	${MAKE} -C ${@} all

clean: ${SUBDIR:=-clean}

${SUBDIR:=-clean}:
	${MAKE} -C ${@:-clean=} clean
