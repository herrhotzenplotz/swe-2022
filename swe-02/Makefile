SUBDIR	=	aufgabe1 \
		aufgabe2 \
		aufgabe3 \
		aufgabe4 \
		aufgabe5 \
		aufgabe6

.PHONY: all clean ${SUBDIR} ${SUBDIR:=-clean}
all: ${SUBDIR}

${SUBDIR}:
	${MAKE} -C ${@} all

clean: ${SUBDIR:=-clean}

${SUBDIR:=-clean}:
	${MAKE} -C ${@:-clean=} clean
