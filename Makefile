# SQL Notebook
# Copyright (C) 2018 Brian Luft
#
# Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
# documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
# rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
# permit persons to whom the Software is furnished to do so, subject to the following conditions:
#
# The above copyright notice and this permission notice shall be included in all copies or substantial portions of the
# Software.
#
# THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
# WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS
# OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
# OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

.PHONY: all
all: linux-debug

.PHONY: clean
clean:
	rm -rf obj-linux-debug bin-linux-debug obj-windows-debug bin-windows-debug obj-mac-debug bin-mac-debug
	rm -rf obj-linux-release bin-linux-release obj-windows-release bin-windows-release obj-mac-release bin-mac-release
	rm -f meson.build run.sh
	find src -name "*.vala.uncrustify" -delete

.PHONY: run
run:
	./run.sh
	
.PHONY: linux-debug
linux-debug:
	PLATFORM=linux BUILDTYPE=debug make internal-docker-build

.PHONY: linux-release
linux-release:
	PLATFORM=linux BUILDTYPE=release make internal-docker-build

.PHONY: windows-debug
windows-debug:
	PLATFORM=windows BUILDTYPE=debug make internal-docker-build

.PHONY: windows-release
windows-release:
	PLATFORM=windows BUILDTYPE=release make internal-docker-build

.PHONY: mac-debug
mac-debug:
	BUILDTYPE=debug /bin/bash build/build-mac.sh

.PHONY: mac-release
mac-release:
	BUILDTYPE=release /bin/bash build/build-mac.sh

.PHONY: format
format:
	docker build -q -t sqlnotebook-uncrustify -f build/Dockerfile.uncrustify .
	docker run --rm -t -v "$(CURDIR)":/source sqlnotebook-uncrustify /bin/bash /source/build/uncrustify.sh

.PHONY: test
test: linux
	obj-linux/tests --verbose

.PHONY: doc
doc: internal-doctoc

# --- internal commands below ---
	
.PHONY: internal-doctoc
internal-doctoc:
	docker build -q -t sqlnotebook-doctoc -f build/Dockerfile.doctoc .
	docker run --rm -t -v "$(CURDIR)":/source sqlnotebook-doctoc /bin/bash /source/build/doctoc.sh

.PHONY: internal-docker-build
internal-docker-build:
	-rm -rf obj-$(PLATFORM)-$(BUILDTYPE)/meson-*
	docker build -q -t sqlnotebook-build-$(PLATFORM) -f build/Dockerfile.build-$(PLATFORM) .
	docker run --rm -t -v "$(CURDIR)":/source sqlnotebook-build-$(PLATFORM) /bin/bash /source/build/build-$(PLATFORM).sh $(BUILDTYPE)
	echo "bin-$(PLATFORM)-$(BUILDTYPE)/sqlnotebook-gui" > run.sh
	chmod +x run.sh
